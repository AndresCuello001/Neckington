using Neckington.Domain.Interfaces;
using Neckington.Domain.Entities;
using Neckington.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.Features.Contacts.UpdateContact
{
     public class UpdateContactsById
     {
        public UpdateContactsById(IContactRepository<Contact> contactRepository) 
        { 
            _contactRepository = contactRepository;  
        }

        public async Task ExecuteContactUpdate(int Id)
        {
           var contact = await _contactRepository.GetByIdAsync(Id);

            if (contact is null)
            {
                throw new Exception("Contact not found");
            }
            else
            {
                await SaveContactUpdate(contact);
            }        
        }

        public async Task SaveContactUpdate(Contact contactUdpated)
        {
            await _contactRepository.UpdateAsync(contactUdpated);
        
        }
            
        private readonly IContactRepository<Contact> _contactRepository;
     }
}
