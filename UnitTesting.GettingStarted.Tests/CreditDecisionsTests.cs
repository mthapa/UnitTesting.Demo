using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class CreditDecisionTests
    {
        Mock<ICreditDecisionService> mockCreditDecisionService;

        CreditDecision systemUnderTest;

        [TestCase(100, "Declined")]
        [TestCase(549, "Declined")]
        [TestCase(550, "Maybe")]
        [TestCase(674, "Maybe")]
        [TestCase(674, "We look forward to doing business with you!")]
        [Ignore("Use the Other Test Case Source Example")]
        public void MakeCreditDecision_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mockCreditDecisionService.Setup(p => p.GetCreditDecision(creditScore)).Returns(expectedResult);


            systemUnderTest = new CreditDecision(mockCreditDecisionService.Object);
            var result = systemUnderTest.MakdeCreditDecision(creditScore);

            Assert.That(result, Is.EqualTo(expectedResult));

            mockCreditDecisionService.VerifyAll();
        }




        [TestCaseSource(typeof(CreditDecisionsTestData), "GetTestCases")]
        public void MakeCreditDecision_WithTestSource_Always_ReturnsExpectedResult(int creditScore, string expectedResult)
        {
            mockCreditDecisionService = new Mock<ICreditDecisionService>(MockBehavior.Strict);
            mockCreditDecisionService.Setup(p => p.GetCreditDecision(creditScore)).Returns(expectedResult);


            systemUnderTest = new CreditDecision(mockCreditDecisionService.Object);
            var result = systemUnderTest.MakdeCreditDecision(creditScore);

            Assert.That(result, Is.EqualTo(expectedResult));

            mockCreditDecisionService.VerifyAll();
        }
    }
}
