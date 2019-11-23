using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly IBusHandler Bus;
        //Adicionar repositorio

        public WheelOfFortuneApplicationService(IBusHandler bus, IMapper mapper)
        {
            _mapper = mapper;
            Bus = bus;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public WheelOfFortuneViewModel Get()
        {
            //_mapper.Map<WheelOfFortuneViewModel>(_repository.Get());
            return new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Green, Id = new Guid(), Number = 3 };
        }
    }
}
