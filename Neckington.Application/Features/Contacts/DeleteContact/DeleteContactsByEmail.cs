
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
       
        public async Task GiveContactToDelete(int Id)
        {
            var contact= await _contactRepository.GetByIdAsync(Id);

            if (contact == null)
            {
                throw new Exception("Contact not found");
            }
            else
            {
                EliminateContact(contact);
            }
        }
        
        public void EliminateContact(Contact contact)
        {
            _contactRepository.DeleteAsync(contact);
        }

        private readonly IContactRepository<Contact> _contactRepository;
    }
}
