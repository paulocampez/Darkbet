using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Core.Commands;
using MediatR;
using System;
using System.Threading.Tasks;

namespace Darkbet.Infra.CrossCutting.Bus
{
    public class InMemoryBus : IBusHandler
    {
        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
