using AutoMapper;
using AutoMapper.QueryableExtensions;
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
            GC.SuppressFinalize(this);
        }

        public WheelOfFortuneViewModel GenerateNewRoll()
        {
            var wheelFortuneViewModel = new WheelOfFortuneViewModel();
            var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            Bus.SendCommand(registerCommand);
            return _mapper.Map<WheelOfFortuneViewModel>(_repository.GetById(wheelFortuneViewModel.Id));
        }

        public WheelOfFortuneViewModel Get()
        {
            var wheelFortuneViewModel = new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Black, Id = Guid.NewGuid(), Number = 3 };
            var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            Bus.SendCommand(registerCommand);
            return _mapper.Map<WheelOfFortuneViewModel>(_repository.Get());
        }
        public IEnumerable<WheelOfFortuneViewModel> GetAll()
        {
            var wheelFortuneViewModel = new WheelOfFortuneViewModel() { Color = Domain.Enums.WheelOfFortuneEnum.WheelOfFortuneColors.Black, Id = Guid.NewGuid(), Number = 3 };
            var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            Bus.SendCommand(registerCommand);
            return _repository.GetAll().ProjectTo<WheelOfFortuneViewModel>(_mapper.ConfigurationProvider);
        }
        public WheelOfFortuneViewModel GetById(Guid id)
        {
            //var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            //Bus.SendCommand(registerCommand);
            return _mapper.Map<WheelOfFortuneViewModel>(_repository.GetById(id));
        }

        public WheelOfFortuneViewModel GetLast()
        {
            //var registerCommand = _mapper.Map<RegisterNewRoundCommand>(wheelFortuneViewModel);
            //Bus.SendCommand(registerCommand);
            return _mapper.Map<WheelOfFortuneViewModel>(_repository.GetAll());
        }
    }
}
