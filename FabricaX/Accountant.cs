using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaX
{
    class Accountant: AccountantRights
    {
        private string accountant;

        public Accountant() {
            accountant = roles[1].ToString();
            showRights();
        }
        private void showRights() {
            maintainReports(accountant);
            assesRisks(accountant);
            evaluateFinancialOperations(accountant);


        }
    }
}
