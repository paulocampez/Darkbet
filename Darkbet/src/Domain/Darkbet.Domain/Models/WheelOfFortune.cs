using Darkbet.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Domain.Models
{
    public class WheelOfFortune : Entity
    {
        public WheelOfFortune(Guid id, int number, WheelOfFortuneColors color, DateTime date)
        {
            Id = id;
            Number = number;
            Color = WheelOfFortuneColors.Green;
            Date = date;
        }

        //EF
        //protected WheelOfFortune() { }
        public int Number { get; set; }
        public WheelOfFortuneColors Color { get; set; }
        public DateTime Date { get; set; }
    }
}
