using System;


namespace FabricaX
{
    public class Roles
    {
        static int number = 0;
       protected object[] roles = new object[] { "administrator", "accountant", "marketer", "worker" };
        public Roles(){

            initialiseRoles(roles.Length);
        
        }


       private void initialiseRoles(int rolesLength) {
            number++;
            if (number <= 1)
            {
                Console.WriteLine("The ranks are: ");
                for (int i = 0; i < rolesLength; i++)
                {
                    Console.Write(roles[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
       }

    }

}
