using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.Tests
{
    public class CreditDecisionsTestData
    {
        public static IEnumerable<TestCaseData> GetTestCases
        {
            get
            {
                yield  return new TestCaseData(100, "Declined");
                yield return new TestCaseData(549, "Declined");
                yield return new TestCaseData(550, "Maybe");
                yield return new TestCaseData(674, "Maybe");
                yield return new TestCaseData(675, "We look forward to doing business with you!");
            }
        }
    }
}
