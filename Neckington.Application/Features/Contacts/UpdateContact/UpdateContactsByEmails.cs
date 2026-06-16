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
     public class UpdateContactsByEmails
     {
        public UpdateContactsByEmails(IContactRepository<Contact> contactRepository) 
        { 
            _contactRepository = contactRepository;  
        }
        
        public void ExecuteContactUpdate(string UserEmail)
        {
            if (string.IsNullOrWhiteSpace(UserEmail))
            {
                throw new Exception("Invalid Email");
            }
            ProcessContactUpdate(UserEmail);
        }

        public async Task ProcessContactUpdate(string UserEmail)
        {
            var contactToUpdate = await _contactRepository.GetByEmailAsync(UserEmail);
            if (contactToUpdate == null)
            {
                throw new Exception("Contact not found");
            }
            SaveContactUpdate(contactToUpdate);
        }

        public void SaveContactUpdate(Contact contactUdpated)
        {
            _contactRepository.UpdateAsync(contactUdpated);
        }

        private readonly IContactRepository<Contact> _contactRepository;
    }
}
