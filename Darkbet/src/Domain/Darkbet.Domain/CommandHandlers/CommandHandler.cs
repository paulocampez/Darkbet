using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Domain.CommandHandlers
{
    public class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IBusHandler _bus;
        public CommandHandler(IUnitOfWork uow, IBusHandler bus)
        {
            _uow = uow;
            _bus = bus;
        }


        public bool Commit()
        {
            if (_uow.Commit()) return true;

            return false;
        }
 
    }
}
