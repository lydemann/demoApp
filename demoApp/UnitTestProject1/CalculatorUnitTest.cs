using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Assert2plus3is5()
        {
            var UUT = new Calculator();
            var result = UUT.AddTwoNumbers(2, 3);
            Assert.AreEqual(result,5);
        }

        [Test]
        public void Assert5plus3is8()
        {
            var UUT = new Calculator();
            var result = UUT.AddTwoNumbers(5, 3);
            Assert.AreEqual(result, 8);
        }
    }
}
