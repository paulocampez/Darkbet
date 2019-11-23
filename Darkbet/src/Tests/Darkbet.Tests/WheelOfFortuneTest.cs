using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Darkbet.Services.Api.Controllers;
using Darkbet.Application.Services;
using AutoMapper;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;

namespace Darkbet.Tests
{
    public class WheelOfFortuneTest
    {
        WheelOfFortuneController _controller;
        WheelOfFortuneApplicationService _service;
        private readonly IMapper _mapper;
        private readonly IBusHandler _bus;
        private readonly IWheelOfFortuneRepository _repository;
        //construtor
        public WheelOfFortuneTest()
        {
            _service = new WheelOfFortuneApplicationService(_repository, _bus, _mapper);
            _controller = new WheelOfFortuneController(_service);
        }

        //Eu quero rodar a roleta e que sai um numero e uma cor
        [Fact]
        public void Retorna_Cor_e_Numero_Test()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }
    }
}
