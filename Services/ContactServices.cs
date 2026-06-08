using Neckington.Core.Interfaces;
using Neckington.Data.Repositories;
using Neckington.Helpers;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.View;
using Neckington.View.ConsoleUI;
using Neckington.DTOs;

namespace Neckington.Services
{
    public class ContactServices
    {
        public ContactServices(ContactRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void ContactCreate(CreateContactDTO contactdto)
        {
            var contact = new Contact()
            {
                Id = contactdto.Id,
                FirstName = contactdto.FirstName,
                LastName = contactdto.LastName,
                PhoneNumber = contactdto.PhoneNumber,
                WorkNumber = contactdto.WorkNumber,
                Address = contactdto.Address,
                DateOfBirth = contactdto.DateOfBirth,
            }; 
                _contactRepository.Add(contact);
        }
        
        public List<Contact> GetAllContacts()
        {
            var contactList = _contactRepository.GetAll();
            return contactList;
        }

        public Contact UpdateContact()
        {
           var userInput = ConsoleUI.CreateContactDtoToUpdate();
            
            if (string.IsNullOrWhiteSpace(userInput))
            {
                throw new Exception("Invalid Email");
            }
            var contactToUpdate = _contactRepository.GetByEmail(userInput);
            if (contactToUpdate == null)
            {   
                    throw new Exception("Contact not found");
            }
            return contactToUpdate;
        }

        public void SaveContactUpdate(Contact contactUdpated) 
        {
            _contactRepository.Update(contactUdpated);
        }
        
        
        public void DeleteCreateContactDto()
        {
            //CreateContactDto CreateContactDtoObject3 = new CreateContactDto();
            //CreateContactDtoObject3.CreateContactDtoDelete();
        }

        private readonly ContactRepository<Contact> _contactRepository;
    }
}



