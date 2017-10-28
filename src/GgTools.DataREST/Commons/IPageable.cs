﻿using System.Collections.Generic;

namespace GgTools.DataREST.Commons
{
    /// <summary>
    /// interface of pageable
    /// </summary>
    public interface IPageable
    {
        /// <summary>
        /// page number
        /// </summary>
        int PageNumber { get; }
        /// <summary>
        /// page size
        /// </summary>
        int PageSize { get; }
       
        /// <summary>
        /// 
        /// </summary>
        List<Sort> Sort { get; }
    }
}