using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        BlogContext context = new BlogContext();
        public void Delete(T entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
