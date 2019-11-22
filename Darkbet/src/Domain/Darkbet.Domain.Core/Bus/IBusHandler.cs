using Darkbet.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Darkbet.Domain.Core.Bus
{
    public interface IBusHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
