
using Neckington.Domain.Entities;
using Neckington.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.Features.Contacts.DeleteContact
{
     public class DeleteContactsByEmail
    {
        public DeleteContactsByEmail(IContactRepository<Contact> contactRepository)
        { 
             _contactRepository = contactRepository;
        }
        public async Task SelectContactDelete(string UserEmail)
        {
            if (string.IsNullOrWhiteSpace(UserEmail))
            {
                throw new Exception("Invalid Email");
            }

           await GiveContactToDelete(UserEmail);
        }
        
        public async Task<Contact> GiveContactToDelete(string UserEmail)
        {
            var contactToEliminate = await _contactRepository.GetByEmailAsync(UserEmail);
            if (contactToEliminate == null)
            {
                throw new Exception("Contact not found");
            }
            return contactToEliminate;
        }

        public void EliminateContact(Contact contact)
        {
            _contactRepository.DeleteAsync(contact);
        }

        private readonly IContactRepository<Contact> _contactRepository;
    }
}
