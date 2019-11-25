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
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;

namespace Darkbet.Domain.CommandHandlers
{
    public class WheelOfFortuneCommandHandler : CommandHandler, IRequestHandler<RegisterNewRoundCommand, bool>
    {
        private readonly IBusHandler Bus;
        private readonly IWheelOfFortuneRepository _repository;
        public WheelOfFortuneCommandHandler(IWheelOfFortuneRepository repository, IUnitOfWork uow, IBusHandler bus) : base(uow, bus)
        {
            _repository = repository;
            Bus = bus;
        }
        public Task<bool> Handle(RegisterNewRoundCommand request, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            Array values = Enum.GetValues(typeof(WheelOfFortuneColors));
            WheelOfFortuneColors randomColor = (WheelOfFortuneColors)values.GetValue(rnd.Next(values.Length));

            var wheelOfFortune = new WheelOfFortune(request.Id, request.Number, request.Color, request.Date);
            wheelOfFortune.Number = rnd.Next(1, 101);
            wheelOfFortune.Color = randomColor;
            wheelOfFortune.Date = DateTime.Now;
            _repository.Add(wheelOfFortune);

            Commit();
            return Task.FromResult(true);
        }
    }
}
