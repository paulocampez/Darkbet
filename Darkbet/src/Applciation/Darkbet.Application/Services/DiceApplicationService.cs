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
    public class DiceApplicationService : IDiceApplicationService
    {
        private readonly IMapper _mapper;
        private readonly IBusHandler Bus;
        private readonly IDiceRepository _repository;

        public DiceApplicationService(IDiceRepository repository, IBusHandler bus, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            Bus = bus;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DiceViewModel Roll()
        {
            var diceViewModel = new DiceViewModel();
            var registerCommand = _mapper.Map<RegisterNewRollCommand>(diceViewModel);
            Bus.SendCommand(registerCommand);
            return _mapper.Map<DiceViewModel>(_repository.GetById(diceViewModel.Id));
        }
    }
}
