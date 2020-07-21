using System;


namespace FabricaX
{
    public class Roles
    { 
       protected object[] roles = new object[] { "administrator", "accountant", "marketer", "worker" };
        public Roles(){

            initialiseRoles(roles.Length);
        
        }


       private void initialiseRoles(int rolesLength) {
            Console.WriteLine("The ranks are: ");
                 for (int i = 0; i < rolesLength; i++)
                 {
                   Console.Write(roles[i] + ", ");
                 }
       }

    }

}
