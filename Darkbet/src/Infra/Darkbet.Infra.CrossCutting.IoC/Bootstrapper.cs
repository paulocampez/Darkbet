using Darkbet.Application.Interfaces;
using Darkbet.Application.Services;
using Darkbet.Domain.CommandHandlers;
using Darkbet.Domain.Commands;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;
using Darkbet.Infra.CrossCutting.Bus;
using Darkbet.Infra.Data.Context;
using Darkbet.Infra.Data.Repository;
using Darkbet.Infra.Data.UoW;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Darkbet.Infra.CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            // Mediatr
            service.AddScoped<IBusHandler, InMemoryBus>();
            // Application
            service.AddScoped<IWheelOfFortuneApplicationService, WheelOfFortuneApplicationService>();
            service.AddScoped<IDiceApplicationService, DiceApplicationService>();
            // Domain 
            service.AddScoped<IRequestHandler<RegisterNewRoundCommand, bool>, WheelOfFortuneCommandHandler>();
            service.AddScoped<IRequestHandler<RegisterNewRollCommand, bool>, DiceCommandHandler>();
            // Infra 
            service.AddScoped<IWheelOfFortuneRepository, WheelOfFortuneRepository>();
            service.AddScoped<IDiceRepository, DiceRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<DarkbetContext>();
        }
    }
}
