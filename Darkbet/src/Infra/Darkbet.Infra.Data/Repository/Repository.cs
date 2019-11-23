using Darkbet.Domain.Interfaces;
using Darkbet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darkbet.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DarkbetContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DarkbetContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity Get()
        {
            return DbSet.First();
        }
    }
}
