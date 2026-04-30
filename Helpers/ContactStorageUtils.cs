using Neckington.Interfaces;
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
    public class ContactStorageUtils : IContactService
    {
        public ContactItem ContactDialog()
        {
            var contact = new ContactItem();

            Console.Clear();
            Console.WriteLine("Introduce the firstname:");
            contact.FirstName = Console.ReadLine() ?? "0";

            Console.WriteLine("Introduce the lastname:");
            contact.LastName = Console.ReadLine() ?? "0";

            Console.WriteLine("Introduce the age");
            contact.Age = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Introduce number:");
            contact.Number = long.Parse(Console.ReadLine() ?? "0");

            return contact;
        }

        public void ContactStorageMethod(ContactItem contact)
        {
            Console.Clear();
            Console.WriteLine("\nContacto Guardado!");
            Console.WriteLine("\nFirstName: " + contact.FirstName);
            Console.WriteLine("\nLastName: " + contact.LastName);
            Console.WriteLine("\nAge: " + contact.Age);
            Console.WriteLine("\nNumber: " + contact.Number);
        
        }

        
    }
}









