using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    {
        Calculator calculator = new Calculator();
            [TestMethod]
        public void AdditionTest()
        {
            int expected = 109;
            int actual = calculator.Add(23, 86);
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Your answer is {actual}");
        }
        [TestMethod]
        public void SubtractionTest()
        {
            int expected = -63;
            int actual = calculator.Subtract(23, 86);
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Your answer is {actual}");
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            int expected = 1978;
            int actual = calculator.Multiply(23, 86);
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Your answer is {actual}");
        }
        [TestMethod]
        public void DivisionTest()
        {
            double expected = 0.2674419;
            double actual = Math.Round(calculator.Divide(23, 86), 7);
            Assert.AreEqual(expected, actual);
            Console.WriteLine($"Your answer is {actual}");
        }
    }
}
