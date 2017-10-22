using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    class CreditProcessorTests
    {
        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(676, "We look forward to doing business with you!")]
        public void MakeCreditDecisioin_Always_ReturnsExpectedValue(int creditScore, string expectedResult)
        {
            var processor = new CreditProcessor();
            Assert.That(processor.MakeCreditDecision(creditScore), Is.EqualTo(expectedResult));
        }
    }
}
