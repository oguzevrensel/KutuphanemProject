using Kutuphanem.DataAccess.Abstracts;
using Kutuphanem.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphanem.DataAccess.Concretes
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Deleted;
                context.SaveChanges(); // UnitOfWork
            }
        }

        public T Get(Func<T, bool> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList().Where(filter).FirstOrDefault();
            }
        }

        public List<T> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.SaveChanges(); // UnitOfWork
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                context.SaveChanges(); // UnitOfWork
            }
        }
    }
}
