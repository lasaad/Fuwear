using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;
using Fuwear.WebApi.Services.Interfaces;
using Fuwear.WebApi.Services;

namespace Fuwear.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        public FizzBuzzTest()
        {
        }

        [TestMethod]
        public void NoFizzNoBuzz()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            //Act
            string result = service.GetFizzBuzz(1);

            //Assert
            Assert.AreEqual(result, "1");

        }

        [TestMethod]
        public void FizzTest()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            //Act
            string result = service.GetFizzBuzz(3);

            //Assert
            Assert.AreEqual(result, "Fizz");

        }

        [TestMethod]
        public void BuzzTest()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            //Act
            string result = service.GetFizzBuzz(5);

            //Assert
            Assert.AreEqual(result, "Buzz");

        }        
        
        [TestMethod]
        public void FizzBuzzOk()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            //Act
            string result = service.GetFizzBuzz(15);

            //Assert
            Assert.AreEqual(result, "FizzBuzz");

        }


    }
}
