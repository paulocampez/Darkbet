using Darkbet.Application.Interfaces;
using Darkbet.Application.ViewModels;
using Darkbet.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.Services
{
    public class WheelOfFortuneApplicationService : IWheelOfFortuneApplicationService
    {
        private readonly IBusHandler Bus;
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public WheelOfFortuneViewModel Get()
        {
            //Bus.SendCommand()
            return new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Green, Id = new Guid(), Number = 3 };
        }
    }
}
