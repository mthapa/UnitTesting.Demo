using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            var systemUnderTest = new Calculator();
            Assert.That(systemUnderTest.Add(1, 2), Is.EqualTo(3));
            
        }


        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(214748369, 10)]
        public void Add_Always_ReturnsExpectedResult(int lhs, int rhs)
        {
            var systemUnderTest = new Calculator();
            int expected = lhs + rhs;
            Assert.That(systemUnderTest.Add(lhs, rhs), Is.EqualTo(expected));

        }
      
    }
}
