using Darkbet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.Interfaces
{
    public interface IDiceApplicationService : IDisposable
    {
        DiceViewModel Roll();
    }
}
