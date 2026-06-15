using Microsoft.EntityFrameworkCore.Update.Internal;
using Neckington.Core;
using Neckington.Core.Configuration;
using Neckington.Core.Factory;
using Neckington.Data;
using Neckington.Application.DTOs;
using Neckington.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Neckington.Application.Features;

namespace Neckington.View.ConsoleUI
{
   public class ConsoleUI
   {
        public ConsoleUI(ContactServices contactServices)
        { 
            _contactServices = contactServices;
        }
        public int ProcessMenu()
        {
            Console.Clear();
            string selection = InputHelper.ReadRequiredString(Constants.Menu);
            int OptionSelection = InputHelper.ReadInt(selection);
            return OptionSelection;
        }

        public void ShowMenu()
        {
            Console.Clear();
            int NumberSelection = ProcessMenu();
            ExecuteOption(NumberSelection);
        }

        public void ExecuteOption(int NumberSelection)
        {
            try
            {
                switch (NumberSelection)
                {
                    case 1:
                        InitializeCreateContactDtoStorage();
                        break;
                    default:
                        throw new ArgumentException("The selection number doesn't exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
        
        public void InitializeCreateContactDtoStorage()
        {
            try
            {
                ExecuteCreateContactDtoMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ExecuteCreateContactDtoMenu()
        {
            int option = InputHelper.ReadInt(Constants.InitializeCreateContactDtoStorageMenu);
            ShowContactMenu(option);
        }

        public void ShowContactMenu(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    ContactCreation();
                    break;
                case 2:
                    ReadContacts();
                    break;
                case 3:
                    UpdateContact();
                    break;
                case 4:
                    DeleteContact();
                    break;
                default:
                    throw new ArgumentException("Option doesn't exits");
            }
        }

        /*public static void PrintContact(List<Contact> listOfContacts)
        {
            var contactList = listOfContacts.OrderBy(c => c.Id).ToList();

            foreach (var Items in contactList)
            {
                Console.WriteLine(Constants.ShowCreateContactDtoDTO);
                Console.WriteLine(new string('-', 50));
            }
        }*/

        public void ContactCreation()
        {
            Console.Clear();
            var contactDTO = new ContactDTO();

            contactDTO.FirstName = InputHelper.ReadRequiredString(Constants.FirstName);
            contactDTO.LastName = InputHelper.ReadRequiredString(Constants.LastName);
            contactDTO.DateOfBirth = InputHelper.ReadRequiredDateTime(Constants.DateOfBirth);
            contactDTO.UserEmail = InputHelper.ReadRequiredString(Constants.Email);
            contactDTO.PhoneNumber = InputHelper.ReadInt(Constants.PhoneNumber);
            contactDTO.WorkNumber = InputHelper.ReadLong(Constants.WorkNumber);
            contactDTO.Address = InputHelper.ReadRequiredString(Constants.Address);

            _contactServices.ContactCreate(contactDTO);
        }

        public void ReadContacts() 
        {
            var contactList = _contactServices.GetAllContacts();
        }
       
        public void UpdateContact()
        {
            var userInput = InputHelper.ReadRequiredString(Constants.GmailRequest);
            _contactServices.ExecuteContactUpdate(userInput);
            InitContactUpdate(userInput);
        }
        public void InitContactUpdate(string userEmail)
        {
            var contactSelected =  _contactServices.ProcessContactUpdate(userEmail);
            var newFirstName = InputHelper.ReadRequiredString($"Actual firstname: " + contactSelected.FirstName);
            if (!String.IsNullOrEmpty(newFirstName)) 
            {
                contactSelected.FirstName = newFirstName;
            }
            
            var newLastName = InputHelper.ReadRequiredString($"Actual LastName: " + contactSelected.LastName);
            if (!String.IsNullOrEmpty(newLastName))
            {
                contactSelected.LastName = newLastName;
            }

            var newEmail = InputHelper.ReadRequiredString($"Actual Email: " + contactSelected.UserEmail);
            if (!String.IsNullOrEmpty(newEmail))
            {
                contactSelected.UserEmail = newEmail;
            }

            var newPhoneNumber = InputHelper.ReadRequiredString($"Actual PhoneNumber: " + contactSelected.PhoneNumber);
            if (!String.IsNullOrEmpty(newPhoneNumber) && long.TryParse(newPhoneNumber, out long phoneNum))
            {
                contactSelected.PhoneNumber = phoneNum;
            }

            var newWorkNumber = InputHelper.ReadRequiredString($"Actual WorkNumber: " + contactSelected.WorkNumber);
            if (!String.IsNullOrEmpty(newWorkNumber) && long.TryParse(newWorkNumber, out long workNum))
            {
                contactSelected.WorkNumber = workNum;
            }

            var newBirthDate = InputHelper.ReadRequiredString($"Actual BirthDate: " + contactSelected.DateOfBirth);
            if (!String.IsNullOrEmpty(newBirthDate) && DateTime.TryParse(newBirthDate, out DateTime birthDate))
            {
                contactSelected.DateOfBirth = birthDate;
            }

            var newAddress = InputHelper.ReadRequiredString($"Actual Address: " + contactSelected.Address);
            if (!String.IsNullOrEmpty(newAddress))
            {
                contactSelected.Address = newAddress;
            }
            _contactServices.SaveContactUpdate(contactSelected);
        }

        public void DeleteContact() 
        {
            var userInput = InputHelper.ReadRequiredString(Constants.GmailToEliminateContact);
            ExecuteContactDeletion(userInput);
        }
      
        public void ExecuteContactDeletion(string userEmail) 
        {
            var contactToEliminate = _contactServices.SelectContactDelete(userEmail);
           
            var response = InputHelper.ReadRequiredString("Are you sure to eliminate this contact?  Press Y/N ");
            if (response == "Y")
            {
                _contactServices.EliminateContact(contactToEliminate);
            }
            else if (response == "N") 
            {
                Console.WriteLine("Contact couldn't be elimate");
            }
        }
        private readonly ContactServices _contactServices;
   }
}
