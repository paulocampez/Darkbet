using Darkbet.Domain.Commands;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Enums;
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
            wheelOfFortune.Number = rnd.Next(1, 37);
            wheelOfFortune.Color = GetColorByNumber(wheelOfFortune.Number);
            wheelOfFortune.Date = DateTime.Now;
            _repository.Add(wheelOfFortune);

            Commit();
            return Task.FromResult(true);
        }

        private WheelOfFortuneColors GetColorByNumber(int number)
        {
            List<int> green = new List<int> { 0 };
            List<int> red = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            List<int> black = new List<int> { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if (green.Contains(number))
                return WheelOfFortuneColors.Green;
            if (red.Contains(number))
                return WheelOfFortuneColors.Red;
            else
                return WheelOfFortuneColors.Black;
        }
    }
}
