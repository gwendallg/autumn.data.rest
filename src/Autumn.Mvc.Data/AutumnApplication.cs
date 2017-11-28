﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using AutoMapper;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.Configurations;
using Autumn.Mvc.Data.Controllers;
using Autumn.Mvc.Data.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Newtonsoft.Json.Serialization;

namespace Autumn.Mvc.Data
{
    public class AutumnApplication
    {
        
        private static readonly NamingStrategy CDefaultNamingStrategy = new DefaultNamingStrategy();
        private const string CDefaultPageSizeFieldName = "PageSize";
        private const string CDefaultSortFieldName = "Sort";
        private const string CDefaultPageNumberFieldName = "PageNumber";
        private const string CDefaultQueryFieldName = "Query";
        private const int CDefaultPageSize = 100;
        private const string CDefaultApiVersion = "v1";

        static AutumnApplication()
        {
            Current = new AutumnApplication();
        }

        private AutumnApplication()
        {
        }

        public NamingStrategy NamingStrategy { get; private set; }
        public int DefaultPageSize { get; private set; }
        public string PageSizeFieldName { get; private set; }
        public string SortFieldName { get; private set; }
        public string DefaultApiVersion { get; private set; }
        public string PageNumberFieldName { get; private set; }
        public string QueryFieldName { get; private set; }
        public bool PluralizeController { get; set; }
        public bool UseSwagger { get; set; }
        public static AutumnApplication Current { get; }
        public IReadOnlyDictionary<Type, AttributeRouteModel> Routes { get; private set; }
        public IReadOnlyDictionary<string, AutumnIgnoreOperationType> IgnoresPaths { get; set; }
        public IReadOnlyDictionary<Type, AutumnEntityInfo> EntitiesInfos { get; private set; }

        public static void Initialize(AutumnOptions autumnOptions,Assembly callingAssembly)
        {
            lock (Current)
            {
                Current.NamingStrategy = autumnOptions.NamingStrategy ?? CDefaultNamingStrategy;
                Current.DefaultPageSize = autumnOptions.DefaultPageSize <= 0
                    ? CDefaultPageSize
                    : autumnOptions.DefaultPageSize;
                Current.PageSizeFieldName =
                    (autumnOptions.PageSizeFieldName ?? CDefaultPageSizeFieldName).ToCase(Current.NamingStrategy);
                Current.PageNumberFieldName =
                    (autumnOptions.PageNumberFieldName ?? CDefaultPageNumberFieldName).ToCase(Current.NamingStrategy);
                Current.SortFieldName =
                    (autumnOptions.SortFieldName ?? CDefaultSortFieldName).ToCase(Current.NamingStrategy);
                Current.QueryFieldName =
                    (autumnOptions.QueryFieldName ?? CDefaultQueryFieldName).ToCase(Current.NamingStrategy);
                Current.PluralizeController = autumnOptions.PluralizeController;
                Current.UseSwagger = autumnOptions.UseSwagger;
                Current.DefaultApiVersion = autumnOptions.DefaultApiVersion ?? CDefaultApiVersion;
                BuildEntitiesInfos(autumnOptions, callingAssembly);
                BuildRoutes(autumnOptions);
            }
        }

        /// <summary>
        /// build EntitiesInfos
        /// </summary>
        private static void BuildEntitiesInfos(AutumnOptions autumnOptions,Assembly callingAssembly)
        {
            var items = new Dictionary<Type, AutumnEntityInfo>();
            foreach (var type in (autumnOptions.EntityAssembly??callingAssembly).GetTypes())
            {
                var entityAttribute = type.GetCustomAttribute<AutumnEntityAttribute>(false);
                if (entityAttribute == null) continue;
                var ignoreOperationAttribute = type.GetCustomAttribute<AutumnIgnoreOperationAttribute>(false);
                AutumnEntityKeyInfo entityKeyInfo = null;
                foreach (var property in type.GetProperties())
                {
                    var keyAttribute = property.GetCustomAttribute<AutumnKeyAttribute>();
                    if (keyAttribute == null) continue;
                    entityKeyInfo = new AutumnEntityKeyInfo(property, keyAttribute);
                    break;
                }
                if (entityKeyInfo == null) continue;
                var proxyTypes = CreateProxyRequestTypeHelper.CompileResultType(type);
                items.Add(type,
                    new AutumnEntityInfo(type, proxyTypes, entityAttribute, entityKeyInfo, ignoreOperationAttribute));
            }

            Mapper.Reset();

            Mapper.Initialize(c =>
            {
                foreach (var entityInfo in items.Values)
                {
                    foreach (var proxyType in entityInfo.ProxyTypes.Values)
                    {
                        c.CreateMap(proxyType, entityInfo.EntityType);
                    }
                }
            });

            Current.EntitiesInfos = new ReadOnlyDictionary<Type, AutumnEntityInfo>(items);
        }

        /// <summary>
        /// build routes
        /// </summary>
        /// <returns></returns>
        private static void BuildRoutes(AutumnOptions autumnOptions)
        {
            var routes = new Dictionary<Type, AttributeRouteModel>();
            var ignorePaths = new Dictionary<string, AutumnIgnoreOperationType>();
            var baseType = typeof(RepositoryControllerAsync<,,,>);
            foreach (var entityType in Current.EntitiesInfos.Keys)
            {
                var info = Current.EntitiesInfos[entityType];
                var name = info.Name;
                switch (autumnOptions.NamingStrategy)
                {
                    case SnakeCaseNamingStrategy _:
                        name = name.ToSnakeCase();
                        break;
                    case CamelCaseNamingStrategy _:
                        name = name.ToCamelCase();
                        break;
                }
                if (autumnOptions.PluralizeController && !name.EndsWith("s"))
                {
                    name = name + "s";
                }
                name = string.Format("{0}/{1}", info.ApiVersion, name);
                var entityKeyType = info.KeyInfo.Property.PropertyType;
                var controllerType = baseType.MakeGenericType(
                    info.EntityType,
                    info.ProxyTypes[AutumnIgnoreOperationPropertyType.Insert],
                    info.ProxyTypes[AutumnIgnoreOperationPropertyType.Update],
                    entityKeyType);
                var attributeRouteModel = new AttributeRouteModel(new RouteAttribute(name));
                routes.Add(controllerType, attributeRouteModel);
                if (info.IgnoreOperations != null)
                {
                    ignorePaths.Add("/" + name, info.IgnoreOperations.Value);
                }
            }
            Current.IgnoresPaths = new ReadOnlyDictionary<string, AutumnIgnoreOperationType>(ignorePaths);
            Current.Routes = new ReadOnlyDictionary<Type, AttributeRouteModel>(routes);
        }
    }
}