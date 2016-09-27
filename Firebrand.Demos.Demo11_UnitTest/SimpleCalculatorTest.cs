using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firebrand.Demos
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void SuvTest()
        {
            //Arrange
            int actual, expected, negexpected;
            expected = 25;
            negexpected = 30;

            SimpleCalculator calc = new SimpleCalculator();

            // Act
            actual = calc.Suv(35, 10);

            // Assert

            Assert.AreEqual(expected, actual, "Expected and actual values do not match");
            Assert.AreNotEqual(negexpected, actual, "Expected and actual values do not match");


        }
    }
}
