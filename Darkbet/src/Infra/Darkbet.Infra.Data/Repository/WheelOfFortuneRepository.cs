using Darkbet.Domain.Interfaces;
using Darkbet.Domain.Models;
using Darkbet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darkbet.Infra.Data.Repository
{
    public class WheelOfFortuneRepository : Repository<WheelOfFortune>, IWheelOfFortuneRepository
    {
        public WheelOfFortuneRepository(DarkbetContext db) : base(db)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IQueryable<WheelOfFortune> GetAll()
        {
            return base.GetAll();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
