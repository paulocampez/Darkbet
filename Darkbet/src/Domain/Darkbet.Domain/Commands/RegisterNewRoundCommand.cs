using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Domain.Commands
{
    public class RegisterNewRoundCommand : WheelOfFortuneCommand
    {
        public RegisterNewRoundCommand(int number, WheelOfFortuneColors color, DateTime date)
        {
            Number = number;
            Color = color;
            Date = date;
        }

    }
}
