using Neckington.Core.Factory;
using Neckington.Core.Interfaces;
using Neckington.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Neckington.Services
{
    public class ContactServices
    {
        public Contact ContactCreation()
        {
            var contact = ContactFactory.Create();

            Console.Clear();

            contact.FirstName = InputHelper.ReadRequiredString("Introduce the first name: ");

            contact.LastName = InputHelper.ReadRequiredString("Introduce the last name: ");

            contact.DateOfBirth = InputHelper.ReadRequiredDateTime("Introduce the Date Of birth: ");
            
            contact.UserEmail = InputHelper.ReadRequiredString("Introduce the Email: ");
            
            contact.PhoneNumber = InputHelper.ReadInt("Introduce number: ");

            contact.WorkNumber = InputHelper.ReadLong("Introduce WorkNumber: ");

            contact.Address = InputHelper.ReadRequiredString("Introduce the Address: ");

            return contact;
        }

        public static Contact GetContactCreation()
        {
            var contactServicesObject = new ContactServices();
            var contact = contactServicesObject.ContactCreation();
            return contact;
        }

            public static void PrintContact(List<Contact> contact)
            {
                var contactList = contact.OrderBy(c => c.Id).ToList();

                foreach (var contacts in contactList)
                {
                    Console.WriteLine($@"Contact : {contacts.Id}
                    Contact FirstName: {contacts.FirstName}
                    Contact LastName: {contacts.LastName}
                    Contact Email: {contacts.UserEmail}
                    Contact PhoneNumber: {contacts.PhoneNumber}
                    Contact WorkNumber: {contacts.WorkNumber}
                    Contact Address: {contacts.Address}"
                    );
                }
            }
    }
}

