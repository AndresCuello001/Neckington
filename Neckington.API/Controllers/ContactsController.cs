using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neckington.Application.DTOs;
using Neckington.Application.Features;
using Neckington.Application.Features.Contacts.CreateContact;
using Neckington.Application.Features.Contacts.DeleteContact;
using Neckington.Application.Features.Contacts.ReadContacts;
using Neckington.Application.Features.Contacts.UpdateContact;

namespace Neckington.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        public ContactsController(
            CreateContactUseCases contactUseCases, GetallContacts getAllContacts,
           DeleteContactsByEmail deleteContactsByEmail, UpdateContactsByEmails updateContactsByEmails)
        {
            _contactUseCases = contactUseCases;
            _getall = getAllContacts;
            _deleteContact = deleteContactsByEmail;
            _updateContact = updateContactsByEmails;        
        }
        
        [HttpGet("AllContacts")]
        public async Task<IActionResult> GetallContact()
        {
            var Contactasd = await _getall.GetAllContacts();
            return Ok(Contactasd);
        }

        
        [HttpPost("ContactCreate")]
        public async Task<IActionResult> CreateAction([FromBody] RegisterContactDTO contact)
        {
            var returnsmh = await _contactUseCases.ContactCreate(contact);
            return Ok(returnsmh);
        }

        private readonly CreateContactUseCases _contactUseCases;
        private readonly GetallContacts _getall;
        private readonly DeleteContactsByEmail _deleteContact;
        private readonly UpdateContactsByEmails _updateContact;

    }
}
   



    
    


