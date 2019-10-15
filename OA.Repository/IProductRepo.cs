using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository
{
    public interface IProductRepo<T> where T : Product
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
