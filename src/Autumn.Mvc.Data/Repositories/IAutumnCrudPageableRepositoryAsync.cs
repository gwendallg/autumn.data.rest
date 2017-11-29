﻿using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Data.Models.Paginations;

namespace Autumn.Mvc.Data.Repositories
{
    /// <summary>
    /// inteface of CRUD repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IAutumnCrudPageableRepositoryAsync<TEntity, in TKey>
        where TEntity : class
    {
        /// <summary>
        /// find enity by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindOneAsync(TKey id);

        /// <summary>
        /// find entity by criteria
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="autumnPageable"></param>
        /// <returns></returns>
        Task<AutumnPage<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter=null, AutumnPageable<TEntity> autumnPageable=null);

        /// <summary>
        /// create entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity, TKey id);

        /// <summary>
        /// delete entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> DeleteAsync(TKey id);
    }
}