using Neckington.Core.Factory;
using Neckington.Core.Interfaces;
using Neckington.Data.Repositories;
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
        public ContactServices(ContactRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public static Contact GetContactCreation()
        {
            var contactServicesObject = new ContactServices();
            var contact = contactServicesObject.ContactCreation();
            return contact;
        }

        public static void PrintContact(List<Contact> contact)
        {
            var listOfContacts = contact.OrderBy(c => c.Id).ToList();

            foreach (var items in listOfContacts)
            {
                Console.WriteLine($@"Contact : {items.Id}
                Contact FirstName: {items.FirstName}
                Contact LastName: {items.LastName}
                Contact Email: {items.UserEmail}
                Contact PhoneNumber: {items.PhoneNumber}
                Contact WorkNumber: {items.WorkNumber}
                Contact Address: {items.Address}"
                );
            }
        }

        /*public Contact ContactUpdate()
        {
            var contact = new Contact();

            Console.WriteLine("Enter the values you want to update");
            /
 
         */

        public static void CreateContact()
        {
            var ContactRepository = ContactRepositoryFactory.CreateContactRepository();
            var contact = ContactServices.GetContactCreation();
            ContactRepository.Create(contact);
        }

        public static void ReadContact()
        {

            var contactRepostory = ContactRepositoryFactory.CreateContactRepository();
            var ContactList = contactRepostory.GetAll();
            ContactServices.PrintContact(ContactList);
        }

        public static void UpdateContact()
        {
            //Contact contactObject2 = new Contact();
            //contactObject2.Update();
        }

        public static void DeleteContact()
        {
            //Contact contactObject3 = new Contact();
            //contactObject3.ContactDelete();
        }












        private readonly ContactRepository<Contact> _contactRepository;
    }
}//Ctrl + F replace all the names



