using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.Commands
{
    public class RegisterNewRollCommand : DiceCommand
    {
        public RegisterNewRollCommand(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }
    }
}
