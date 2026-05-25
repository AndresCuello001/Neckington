using Neckington;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Helpers;

namespace Neckington.Models
{
    public class Contact : BaseRegistry
    {
        public Contact ContactCreation()
        {
            Contact contact = new Contact();

            Console.Clear();

            contact.FirstName = InputHelper.ReadRequiredString("Introduce the first name: ");

            contact.LastName = InputHelper.ReadRequiredString("Introduce the last name: ");

            contact.Age = InputHelper.ReadInt("Introduce the age: ");
             
            contact.PhoneNumber = InputHelper.ReadInt("Introduce number: ");
             
            contact.WorkNumber = InputHelper.ReadLong("Introduce WorkNumber: ");

            contact.Address = InputHelper.ReadRequiredString("Introduce the Address: ");

            return contact;
        }

        public void RegisterContact(Contact contact) => Create(contact);
        public override string ToString() =>string.Format(Constants.ContactRegister, Id, FirstName, LastName, Age, PhoneNumber, WorkNumber, Address);

        public void ShowContact() => Read();
       
        public void ContactUpdate() => Update();
        
        public void ContactDelete() => Delete();
        
        public string? Id { get; set; }
        
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; } 
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public long WorkNumber { get; set; }
        public string? Address { get; set; } 

        // public static int counter = 1;
    }
}
