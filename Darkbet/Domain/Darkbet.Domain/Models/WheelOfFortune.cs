using Darkbet.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Models
{
    public class WheelOfFortune : Entity
    {
        public WheelOfFortune(Guid id, int number, string color)
        {
            Id = id;
            Number = number;
            Color = color;
        }

        //EF
        protected WheelOfFortune() { }
        public int Number { get; set; }
        public string Color { get; set; }
    }
}
