using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Codefirst.Database
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        T Get(Expression<Func<T, bool>> where);
        void DelById(Expression<Func<T, bool>> where);
        void Add(T t); 
    }
}