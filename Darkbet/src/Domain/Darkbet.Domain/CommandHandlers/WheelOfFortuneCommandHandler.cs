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
        public WheelOfFortuneCommandHandler(IUnitOfWork uow, IBusHandler bus) : base(uow, bus)
        {
            Bus = bus;
        }
        public Task<bool> Handle(RegisterNewRoundCommand request, CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            Array values = Enum.GetValues(typeof(WheelOfFortuneColors));
            WheelOfFortuneColors randomColor = (WheelOfFortuneColors)values.GetValue(rnd.Next(values.Length));

            var wheelOfFortune = new WheelOfFortune(Guid.NewGuid(), request.Number, request.Color);
            wheelOfFortune.Number = rnd.Next(1, 101);
            wheelOfFortune.Color = randomColor;

            return Task.FromResult(true);
        }
    }
}
