using Darkbet.Domain.Interfaces;
using Darkbet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DarkbetContext _context;

        public UnitOfWork(DarkbetContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
