using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteSawLuz.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(long id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(long id);
        int SaveChanges();
    }
}
