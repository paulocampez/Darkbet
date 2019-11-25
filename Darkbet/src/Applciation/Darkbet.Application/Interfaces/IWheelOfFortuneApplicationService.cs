using Darkbet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.Interfaces
{
    public interface IWheelOfFortuneApplicationService : IDisposable
    {
        WheelOfFortuneViewModel GenerateNewRoll();
        WheelOfFortuneViewModel Get();
        WheelOfFortuneViewModel GetById(Guid id);
        IEnumerable<WheelOfFortuneViewModel> GetAll();
    }
}
