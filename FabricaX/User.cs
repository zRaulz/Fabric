using System;


namespace FabricaX
{
    class User:Roles
    {
        private string userName;
        
        public User(string userName)
        {
            this.userName = userName;
            checkType();
            
        }  
        private void checkType() {
          
                switch (userName)
                {
                    case "administrator":
                    Administrator administrator = new Administrator();
                    
                    Console.WriteLine("You are the administrator"); 
                    break;

                    case "accountant":
                    Accountant accountant = new Accountant();
                    Console.WriteLine("You are the accountant"); 
                    break;

                    case "marketer": 
                    Console.WriteLine("You are the marketer");
                    break;
                    
                    case "worker": 
                    Console.WriteLine("You are the worker");
                    break;

                    default:
                    Console.WriteLine("You have no rights on this db"); 
                    break;
                }
                  
        }       
    }
}
