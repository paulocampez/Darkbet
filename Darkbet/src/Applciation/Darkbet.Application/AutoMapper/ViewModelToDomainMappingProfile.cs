using Darkbet.Application.ViewModels;
using Darkbet.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Darkbet.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<WheelOfFortuneViewModel, RegisterNewRoundCommand>()
                .ConstructUsing(c => new RegisterNewRoundCommand(c.Number, c.Color, c.Date));
            CreateMap<DiceViewModel, RegisterNewRollCommand>()
           .ConstructUsing(c => new RegisterNewRollCommand(c.Number, c.Date));
        }
    }
}
