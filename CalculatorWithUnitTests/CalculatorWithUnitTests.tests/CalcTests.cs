using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorWithUnitTests.tests
{
    [TestClass]
    public class CalcTests
    {

        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Add(13, 17, 43);

            //Assert
            Assert.AreEqual(73, result);
        }
        [TestMethod]
        public void TestAddVeryLargeNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var result = calc.Add(double.MaxValue, double.MaxValue);

            //Assert
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [TestMethod]
        public void TestSubtract()
        {
            var calc = new Calculator();
            var result = calc.Subtract(33, 21);
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void TestMultiply()
        {
            var calc = new Calculator();
            var result = calc.Multiply(17, 3);
            Assert.AreEqual(51, result);
        }
        [TestMethod]
        public void TestDivide()
        {
            var calc = new Calculator();
            var result = calc.Divide(33, 11);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestDivideBy0()
        {
            var calc = new Calculator();
            var result = calc.Divide(33, 0);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [TestMethod]
        public void TestDivideWithNegative()
        {
            var calc = new Calculator();
            var result = calc.Divide(-20, 5);
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void TestExponential()
        {
            var calc = new Calculator();
            var result = calc.Exp(2, 10);
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseEvenExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, 9);
            Assert.AreEqual(-512, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseNegativeEvenExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, -2);
            Assert.AreEqual(.25, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseNegativeOddExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, -3);
            Assert.AreEqual(-.125, result);
        }
    }
}
