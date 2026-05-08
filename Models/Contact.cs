using Neckington.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Models
{
    public class Contact
    {
        public Contact ContactCreation()
        {
            Contact contact = new Contact();

            Console.Clear();

           
            
            Console.WriteLine("Introduce the first name:");
            contact.FirstName = Console.ReadLine() ?? "";

            Console.WriteLine("Introduce the last name:");
            contact.LastName = Console.ReadLine() ?? "";

            Console.WriteLine("Introduce the age:");
            contact.Age = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Introduce number:");
            contact.PhoneNumber = long.Parse(Console.ReadLine() ?? "0");
             
            Console.WriteLine("Introduce WorkNumber:");
            contact.WorkNumber = long.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Introduce the Address:");
            contact.Address = (Console.ReadLine() ?? "0");

            return contact;
        }

        public string Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public long WorkNumber { get; set; }
        public string Address { get; set; } = string.Empty;

        // public static int counter = 1;
    }
}
