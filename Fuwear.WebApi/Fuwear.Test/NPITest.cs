using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;
using Fuwear.WebApi.Services.Interfaces;
using Fuwear.WebApi.Services;

namespace Fuwear.Test
{
    [TestClass]
    public class NPITest
    {
        public NPITest()
        {
        }

        [TestMethod]
        public void CalcComplexe()
        {
            // Arrange
            NPICalcService service = new NPICalcService();

            //Act
            int result = service.GetNPICalc("2 1 5 + *");

            //Assert
            Assert.AreEqual(result, 12);

        }

        [TestMethod]
        public void CalcSimple()
        {
            // Arrange
            NPICalcService service = new NPICalcService();

            //Act
            int result = service.GetNPICalc("1 2 +");

            //Assert
            Assert.AreEqual(result, 3);

        }
    }
}
