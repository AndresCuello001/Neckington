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

            contact.PhoneNumber = InputHelper.ReadInt("Introduce number: ");

            contact.WorkNumber = InputHelper.ReadLong("Introduce WorkNumber: ");

            contact.Address = InputHelper.ReadRequiredString("Introduce the Address: ");

            return contact;
        }

        public static Contact GetContactCreation()
        {
            ContactServices contactServicesObject = new ContactServices();
            var contact = contactServicesObject.ContactCreation();
            return contact;
        }


    }
}
