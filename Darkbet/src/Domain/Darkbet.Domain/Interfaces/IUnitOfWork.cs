using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
