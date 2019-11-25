using Darkbet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.Interfaces
{
    public interface IWheelOfFortuneApplicationService : IDisposable
    {
        void GenerateNewRoll();
        WheelOfFortuneViewModel Get();
        WheelOfFortuneViewModel GetLast();
        WheelOfFortuneViewModel GetById(Guid id);
        IEnumerable<WheelOfFortuneViewModel> GetAll();
    }
}
