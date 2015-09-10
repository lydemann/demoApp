using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Assert2plus3is5()
        {
            var UUT = new Calculator();
            var result = UUT.AddTwoNumbers(2, 3);
            Assert.AreEqual(result,5);
        }
    }
}
