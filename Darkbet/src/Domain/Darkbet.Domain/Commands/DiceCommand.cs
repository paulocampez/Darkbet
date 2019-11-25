using Darkbet.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Commands
{
    public abstract class DiceCommand : Command
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}
