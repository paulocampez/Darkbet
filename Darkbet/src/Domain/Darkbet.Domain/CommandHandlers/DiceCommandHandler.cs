using Darkbet.Domain.Commands;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;
using Darkbet.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Darkbet.Domain.CommandHandlers
{
    public class DiceCommandHandler : CommandHandler, IRequestHandler<RegisterNewRollCommand, bool>
    {
        private readonly IBusHandler Bus;
        private readonly IDiceRepository _repository;
        public DiceCommandHandler(IDiceRepository repository, IUnitOfWork uow, IBusHandler bus) : base(uow, bus)
        {
            _repository = repository;
            Bus = bus;
        }

        public Task<bool> Handle(RegisterNewRollCommand request, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var dice = new Dice(request.Id, request.Number, request.Date);
            dice.Number = rnd.Next(1, 101);
            dice.Date = DateTime.Now;
            _repository.Add(dice);

            Commit();
            return Task.FromResult(true);
        }
    }
}
