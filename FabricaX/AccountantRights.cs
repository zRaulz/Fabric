using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaX
{
    class AccountantRights: Roles, IRolesAccessibility
    {
        public bool enquireEmails(string role) { return false; }
        public bool answerPhoneCalls(string role) { return false; }
        public bool diaryManagement(string role){ return false; }    
        public bool bookMeetings(string role){ return false; }     
        public bool maintainReports(string role) { 
            Console.WriteLine("\n -can maintain reports " + true); 
            return true; 
        }
        public bool assesRisks(string role) { 
            Console.WriteLine("\n -can asses risks " + true); 
            return true;
        }
        public bool evaluateFinancialOperations(string role) {
             Console.WriteLine("\n -can evaluate financial operations " + true);
             return true;
        }
        public bool searchForMarketingTools(string role) { return false; }
        public bool innovate(string role) { return false; }
        public bool followPlansOfAction(string role) { return false; }
        public bool participateInTraining(string role) { return false; }
    }
}
