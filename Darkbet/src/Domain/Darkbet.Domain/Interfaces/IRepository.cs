using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darkbet.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Add(TEntity obj);
        TEntity Get();
        TEntity GetLast();
    }
}
