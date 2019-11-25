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
    public class DiceController : ControllerBase
    {
        private readonly IDiceApplicationService _diceApplicationService;
        public DiceController(IDiceApplicationService diceApplicationService)
        {
            _diceApplicationService = diceApplicationService;
        }

        // GET: api/Dice
        [HttpGet]
        [Route("Roll")]
        public IActionResult Roll()
        {
            return Ok(_diceApplicationService.Roll());
        }

    }
}
