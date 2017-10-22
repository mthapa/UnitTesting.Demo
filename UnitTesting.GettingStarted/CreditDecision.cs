using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted
{
    public class CreditDecision
    {
        ICreditDecisionService creditDeciosinService;

        public CreditDecision(ICreditDecisionService creditDecisionService)
        {
            this.creditDeciosinService = creditDecisionService;
        }

        public string MakdeCreditDecision (int creditScrore)
        {
            return creditDeciosinService.GetCreditDecision(creditScrore);
        }

    }
}
