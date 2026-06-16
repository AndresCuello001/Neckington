
using Neckington.Application.Mappers;
using Neckington.Domain.Entities;
using Neckington.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.Features.Contacts.ReadContacts
{
    public class GetallContacts
    {
        public GetallContacts(IContactRepository<Contact> contactRepository)  
        { 
        
             _contactRepository = contactRepository;
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            var contactList = await _contactRepository.GetAllAsync();

           // ContactMapper.ShowContact(contactList);
            return contactList;
        }

        private readonly IContactRepository<Contact> _contactRepository;
    }
}
