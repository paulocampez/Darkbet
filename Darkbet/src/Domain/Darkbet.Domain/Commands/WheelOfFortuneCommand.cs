using Darkbet.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Domain.Commands
{
    public abstract class WheelOfFortuneCommand : Command
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public WheelOfFortuneColors Color { get; set; }

        public DateTime Date { get; set; }
    }
}
