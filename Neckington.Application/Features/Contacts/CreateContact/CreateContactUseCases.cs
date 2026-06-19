using Neckington.Application.DTOs;
using Neckington.Application.Mappers;
using Neckington.Domain.Entities;
using Neckington.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Neckington.Application.Features.Contacts.CreateContact
{
    public class CreateContactUseCases
    {
        public CreateContactUseCases(IContactRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        
        }
        
        public async Task<Contact> ContactCreate(ContactDTO contact)
        {
            var newContact = ContactMapper.ToEntity(contact);

            await _contactRepository.AddAsync(newContact);

            return newContact;
        }

        private readonly IContactRepository<Contact> _contactRepository;
    }
}
