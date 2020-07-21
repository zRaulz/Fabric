

namespace FabricaX
{
    class Administrator: AdministratorRights

    {
        private string administrator;
        public Administrator()
        {
            administrator = roles[0].ToString();
            showRights();
           
            
        }
     private void showRights(){

            enquireEmails(administrator);
            answerPhoneCalls(administrator);
            diaryManagement(administrator);
            bookMeetings(administrator);

        }
      
        
    }
}
