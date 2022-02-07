using Fuwear.WebApi.Services;
using Fuwear.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuwear.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IEmailService _email;

        public WeatherForecastController(IEmailService email, IPigeonVoyageurService pigeonVoyageur)
        {
            _email = email;
        }

        [HttpGet]
        public string Get()
        {
            return _email.SendMessage();
        }
    }
}
