using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T :class,IEntity
    {
        List<T> GetList(Expression<Func<T,bool>> fliter = null);
        T Get(Expression<Func<T, bool>> fliter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
