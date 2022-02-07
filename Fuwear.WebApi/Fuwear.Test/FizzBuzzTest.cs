using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;
using Fuwear.WebApi.Services.Interfaces;

namespace Fuwear.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        private IFizzBuzz _fizzbuzz { get; set; }

        public FizzBuzzTest()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            IFizzBuzz fournisseurMeteo = Mock.Of<IFizzBuzz>();

            IFizzBuzz obj = Mock.Of<IFizzBuzz>();
            Mock.Get(obj).Setup(x => x.GetFizzBuzz(1)).Returns("1");
            Mock.Get(obj).Setup(x => x.GetFizzBuzz(6)).Returns("Fizz");
            Mock.Get(obj).Setup(x => x.GetFizzBuzz(6)).Returns("Fizz");

        }
    }
}
