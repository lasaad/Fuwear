using Fuwear.WebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuwear.WebApi.Services
{
    public class FizzBuzzService : IFizzBuzz
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        public string GetFizzBuzz(int number)
        {
            string result = number.ToString();
            if (number % 3 == 0 && number % 5 == 0)
                result = $"{fizz}{buzz}";
            else if (number % 3 == 0)
                result = fizz;
            else if (number % 5 == 0)
                result = buzz;
            return result;
        }
    }
}
