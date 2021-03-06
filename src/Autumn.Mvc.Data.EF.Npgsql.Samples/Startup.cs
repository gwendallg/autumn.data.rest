﻿using System;
using Autumn.Mvc.Data.EF.Configuration;
using Autumn.Mvc.Data.EF.Npgsql.Samples.Models;
using Autumn.Mvc.Data.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Npgsql;
using Swashbuckle.AspNetCore.Swagger;

namespace Autumn.Mvc.Data.EF.Npgsql.Samples
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddAutumn(config =>
                    config
                        .NamingStrategy(new SnakeCaseNamingStrategy()))
                .AddAutumnData(config =>
                    config
                        .ApiVersion("v1")
                        .PluralizeController(true)
                )
                .AddAutumnEntityFrameworkCoreNpgsql<ChinookContext>(config =>
                    config
                        .ConnectionString(
                            "server=localhost;Port=5432;Database=chinook;User Id=chinook;password=@utUmn_mvc_D@t@!")
                ).AddSwaggerGen(c =>
                {

                    foreach (var version in services.GetAutumnDataSettings().ApiVersions)
                    {
                        c.SwaggerDoc(version, new Info {Title = "api", Version = version});
                    }
                    c.DocumentFilter<SwaggerDocumentFilter>();
                    c.OperationFilter<SwaggerOperationFilter>();

                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app
                .UseAutumnData()
                .UseSwagger()
                .UseSwaggerUI(c =>
                {
                    foreach (var version in app.GetAutumnDataSettings().ApiVersions)
                    {
                        c.SwaggerEndpoint(string.Format("/swagger/{0}/swagger.json", version),
                            string.Format("API {0}", version));
                    }
                })
                .UseMvc();

            var entityFrameworkCoreSettings = app.GetAutumnEntityFrameworkCoreSettings();

            var logger = loggerFactory?.CreateLogger("Evolve");
            Action<string> log = Console.WriteLine;
            if (logger != null)
            {
                log = (e) =>
                {
                    logger.LogInformation(e);
                };
            }

            using (var connection = new NpgsqlConnection(entityFrameworkCoreSettings.ConnectionString))
            {
                var evolve = new Evolve.Evolve(connection, log);
                evolve.Migrate();
            }

        }

    }
}