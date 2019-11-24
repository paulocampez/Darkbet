using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Darkbet.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Darkbet.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheelOfFortuneController : ControllerBase
    {
        private readonly IWheelOfFortuneApplicationService _wheelOfFortuneApplicationService;
        public WheelOfFortuneController(IWheelOfFortuneApplicationService wheelOfFortuneApplicationService)
        {
            _wheelOfFortuneApplicationService = wheelOfFortuneApplicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_wheelOfFortuneApplicationService.Get());
        }

        //[HttpGet]
        //public IActionResult GetRandom()
        //{
        //    return Ok(_wheelOfFortuneApplicationService.Get());
        //}
    }
}