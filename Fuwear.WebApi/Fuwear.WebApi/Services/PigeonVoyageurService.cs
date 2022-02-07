using Fuwear.WebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuwear.WebApi.Services
{
    public class PigeonVoyageurService : IPigeonVoyageurService

    {
        public string SendMessage()
        {
            return "Pigeon envoyé";
        }
    }
}
