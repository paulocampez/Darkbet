using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get();
    }
}
