using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Codefirst.Models;
using System.Linq.Expressions;

namespace Codefirst.Database
{
    public class Repositorybase<T> : IRepository<T> where T : class
    {
        protected DbContext dbcontext;
        public Repositorybase(DbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public void Add(T t)
        {
            dbcontext.Set<T>().Add(t);
        }

        public void DelById(Expression<Func<T, bool>> where)
        {
            IList<T> Tlist = dbcontext.Set<T>().Where(where).ToList();
            if (Tlist != null && Tlist.Count > 0)
            {
                foreach (T t in Tlist)
                {
                    dbcontext.Set<T>().Remove(t);
                }
                dbcontext.SaveChanges();
            }
        }

        public IQueryable<T> GetAll()
        {
           return dbcontext.Set<T>();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbcontext.Set<T>().Where(where).FirstOrDefault();
        }
    }
}