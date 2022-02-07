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
    public class MessageController : ControllerBase
    {
        private readonly IPigeonVoyageurService _pigeon;
        private readonly IEmailService _email;

        public MessageController(IEmailService email, IPigeonVoyageurService pigeonVoyageur)
        {
            _email = email;
            _pigeon = pigeonVoyageur;
        }

        [HttpGet]
        [Route("EnvoyerMail")]
        public string EnvoyerMail()
        {
            return _email.SendMessage();
        }
        
        [HttpGet]
        public string EnvoyerPigeon()
        {
            return _pigeon.SendMessage();
        }
    }
}
