using Darkbet.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Domain.Models
{
    public class WheelOfFortune : Entity
    {
        public WheelOfFortune(Guid id, int number, string color)
        {
            Id = id;
            Number = number;
            Color = WheelOfFortuneColors.Green;
        }

        //EF
        protected WheelOfFortune() { }
        public int Number { get; set; }
        public WheelOfFortuneColors Color { get; set; }
    }
}
