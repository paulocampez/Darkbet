using Darkbet.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Models
{
    public class Dice : Entity
    {
        public Dice(Guid id, int number, DateTime date)
        {
            Id = id;
            Number = number;
            Date = date;
        }

        //EF
        //protected Dice() { }
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}
