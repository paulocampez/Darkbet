using AutoMapper;
using Darkbet.Application.ViewModels;
using Darkbet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<WheelOfFortune, WheelOfFortuneViewModel>();
        }
    }
}
