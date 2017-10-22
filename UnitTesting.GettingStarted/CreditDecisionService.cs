using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted
{
    public class CreditDecisionService : ICreditDecisionService
    {
        string ICreditDecisionService.GetCreditDecision(int creditScore)
        {
            //if (creditScore < 550)
            //    return "Declined";
            //else if (creditScore <= 675)
            //    return "Maybe";
            //else
                return "We look forward to doing business with you!";
        }
    }
}
