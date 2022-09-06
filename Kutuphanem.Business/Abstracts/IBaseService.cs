using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.Business.Abstracts
{
    public interface IBaseService<T> where T : class, IEntity, new()
    {

        List<T> GetAll();
        T Get(Func<T, bool> filter);


        void Insert(T entity);


        void Update(T entity);


        void Delete(T entity);
    }
}
