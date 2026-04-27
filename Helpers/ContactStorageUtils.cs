using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Neckington.Helpers
{
    public class ContactStorageUtils
    {
        public static void ContactDialog()
        {
            Console.Clear();
            Console.WriteLine("You have select adding contact");
            Console.WriteLine("Write the contact name:");
            string Name = Console.ReadLine() ?? "0";
            Console.WriteLine("Write the contact LastName: ");
            string LastName = Console.ReadLine() ?? "0";
            Console.WriteLine("Write the contact Age: ");
            string Ageparse = Console.ReadLine() ?? "0";
            int Age = int.Parse(Ageparse);
            Console.WriteLine("Write the contact Number: ");
            string entrada4 = Console.ReadLine() ?? "0";

            long Number = long.Parse(entrada4);

            var newContact = new ContactItem()
            {
                FirstName = Name,
                LastName = LastName,
                Age = Age,
                Number = Number
            };
                  Console.WriteLine("Contacto Guardado");
        }
       
        
        
    }

        
        
    
}


