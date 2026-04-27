using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington
{
    public  class ContactStorage
    {
        public static void ContactDialogMethod() {

            Console.Clear();
            Console.WriteLine("You have select adding contact");
            Console.WriteLine("Write the contact name:");
            string entrada = Console.ReadLine() ?? "0";
            Console.WriteLine("Write the contact LastName: ");
            string entrada2 = Console.ReadLine() ?? "0";
            Console.WriteLine("Write the contact Age: ");
            string entrada3 = Console.ReadLine() ?? "0";
            int Age1 = int.Parse(entrada3);
            Console.WriteLine("Write the contact Number: ");
            string entrada4 = Console.ReadLine() ?? "0";
            
            int Number = int.Parse(entrada4);
           
            var Contact = new ContactStorage()
            {






            };
        
            
            
        }
    
    
    }
}
