using Darkbet.Domain.Interfaces;
using Darkbet.Domain.Models;
using Darkbet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darkbet.Infra.Data.Repository
{
    public class DiceRepository : Repository<Dice>, IDiceRepository
    {
        public DiceRepository(DarkbetContext db) : base(db)
        {

        }
        public override IQueryable<Dice> GetAll()
        {
            return base.GetAll();
        }
    }
}