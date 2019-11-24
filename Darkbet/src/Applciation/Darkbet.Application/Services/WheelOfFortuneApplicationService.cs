using AutoMapper;
using Darkbet.Application.Interfaces;
using Darkbet.Application.ViewModels;
using Darkbet.Domain.Commands;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.Services
{
    public class WheelOfFortuneApplicationService : IWheelOfFortuneApplicationService
    {
        private readonly IMapper _mapper;
        private readonly IBusHandler Bus;
        private readonly IWheelOfFortuneRepository _repository;

        public WheelOfFortuneApplicationService(IWheelOfFortuneRepository repository, IBusHandler bus, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            Bus = bus;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public WheelOfFortuneViewModel Get()
        {
            var wheelFortuneViewModel = new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Black, Id = Guid.NewGuid(), Number = 3 };
            var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            Bus.SendCommand(registerCommand);
            return _mapper.Map<WheelOfFortuneViewModel>(_repository.Get());
            
            //return new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Green, Id = new Guid(), Number = 3 };
        }
    }
}
