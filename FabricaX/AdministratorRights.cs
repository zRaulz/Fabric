using System;


namespace FabricaX
{
    class AdministratorRights: Roles,IRolesAccessibility
    {
       public bool enquireEmails(string role)
        {
            Console.WriteLine("\n-can enquire emails " + true);
            return true;
        }
       public bool answerPhoneCalls(string role)
        {
            Console.WriteLine("-can answer phone calls "+ true);
            return true;
        }
        public bool diaryManagement(string role)
        {
            Console.WriteLine("-can manage the diary "+true);
            return true;
        }
        public bool bookMeetings(string role)
        {
            Console.WriteLine("-can book meetings. "+true);
            return true;
        }
        public bool maintainReports(string role) { return false; }
        public bool assesRisks(string role) { return false; }
        public bool evaluateFinancialOperations(string role) { return false; }
        public bool searchForMarketingTools(string role) { return false; }
        public bool innovate(string role) { return false; }
        public bool followPlansOfAction(string role) { return false; }
        public bool participateInTraining(string role) { return false; }
    }
}
