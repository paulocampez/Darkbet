using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Darkbet.Services.Api.Controllers;
using Darkbet.Application.Services;
using AutoMapper;
using Darkbet.Domain.Core.Bus;
using Darkbet.Domain.Interfaces;
using Moq;
using System.Threading.Tasks;
using Darkbet.Domain.Models;
using System.Collections.Generic;
using static Darkbet.Domain.Enums.WheelOfFortuneEnum;
using Darkbet.Application.ViewModels;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Darkbet.Infra.CrossCutting.Bus;
using MediatR;

namespace Darkbet.Tests
{
    public class WheelOfFortuneTest
    {
        WheelOfFortuneController _controller;
        //WheelOfFortuneApplicationService _service;
        //private readonly IMapper _mapper;
        //private readonly IBusHandler _bus;
        //private readonly IWheelOfFortuneRepository _repository;
  
        //construtor
        public WheelOfFortuneTest()
        {
            var fakeMediator = new Mock<IMediator>();
            var fakedResult = new TestResult(new TestCase());
            var mediator = new InMemoryBus(fakeMediator.Object);
            var wheelOFFortuneModel = new WheelOfFortune(Guid.NewGuid(), 3, WheelOfFortuneColors.Black, DateTime.Now);
            var wheelOFFortuneVM = new WheelOfFortuneViewModel();
            var mockRepo = new Mock<IWheelOfFortuneRepository>();
            var mapperMock = new Mock<IMapper>();

            mockRepo.Setup(repo => repo.Get()).Returns(Task.FromResult(GetTestWheelOfFortune()).Result);
            mapperMock.Setup(m => m.Map<WheelOfFortune, WheelOfFortuneViewModel>(wheelOFFortuneModel)).Returns(wheelOFFortuneVM);

            var service = new WheelOfFortuneApplicationService(mockRepo.Object, mediator, mapperMock.Object);
            _controller = new WheelOfFortuneController(service);
        }

        //Eu quero rodar a roleta e que sai um numero e uma cor
        [Fact]
        public void Retorna_Cor_e_Numero_Test()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }

        private WheelOfFortune GetTestWheelOfFortune()
        {
            return new WheelOfFortune(Guid.NewGuid(), 3, WheelOfFortuneColors.Black, DateTime.Now);
        }
    }
}
