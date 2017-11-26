﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Datas.UnitOfWorks;

namespace Bing.Datas.EntityFramework
{
    /// <summary>
    /// EF工作单元 扩展
    /// </summary>
    public static partial class UnitOfWorkExtensions
    {
        /// <summary>
        /// 清空缓存
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public static void ClearCache(this IUnitOfWork unitOfWork)
        {
            var dbContext = unitOfWork as DbContext;
            dbContext?.ChangeTracker.Entries().ToList().ForEach(entry => entry.State = EntityState.Detached);
        }
    }
}
