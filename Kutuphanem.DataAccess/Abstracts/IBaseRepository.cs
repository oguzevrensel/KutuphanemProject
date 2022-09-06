using Kutuphanem.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphanem.DataAccess.Abstracts
{
    public interface IBaseRepository<T> where T:class, IEntity, new()
    {
        // CRUD

        //R -> Retrieve
        List<T> GetAll();
        T Get(Func<T, bool> filter); //LINQ

        //Create
        void Insert(T entity);

        //Update
        void Update(T entity);

        //Delete
        void Delete(T entity);
    }
}
