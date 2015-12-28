using GEP.Core;
using GEP.Core.Models;
using GEP.Core.SchoolsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data.Interfaces
{
    /// <summary>
    ///     Sample repository class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial interface ICrudDao<T>
        where T : BaseEntity
    {
        IList<T> GetAll();
        T First(Expression<Func<T, bool>> predicate);
        void Add(T entity);        
        void Update(T entity);
        void Remove(Expression<Func<T, bool>> predicate);
    }

    #region TODO For Caching
    /// <summary>
    /// Indicates that the service supports caching.
    /// </summary>
    //public interface IEntityCachable<TEntity, TId>
    //    where TEntity : BaseEntity, IPrimaryKey<TId>
    //    where TId : IComparable
    //{
    //    /// <summary>
    //    /// Gets or sets the cache.
    //    /// </summary>
    //    /// <value>The cache.</value>
    //    IEntityCache<TEntity, TId> Cache
    //    {
    //        get;
    //        set;
    //    }
    //}
    #endregion

    public interface IJobDao : ICrudDao<job>
    {
        List<job> GetAllByDescription(string desription);
    }

    public interface IEmployeeDao : ICrudDao<employee>
    {
        List<employee> GetByJobDescription(string jobDescription);
    }

    public interface ICourseDao : ICrudDao<Course>
    {
    }
}
