using System;
using System.Collections.Generic;
using System.Text;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Application.ViewModels
{
    public class WheelOfFortuneViewModel
    {
        public Guid Id { get; set; }
        public WheelOfFortuneColors Color { get; set; }
        public int Number { get; set; }
        
        public DateTime Date { get; set; }
    }
}
