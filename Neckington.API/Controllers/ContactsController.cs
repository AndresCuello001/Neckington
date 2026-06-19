using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neckington.Application.DTOs;
using Neckington.Application.Features;
using Neckington.Application.Features.Contacts.CreateContact;
using Neckington.Application.Features.Contacts.DeleteContact;
using Neckington.Application.Features.Contacts.ReadContacts;
using Neckington.Application.Features.Contacts.UpdateContact;
using Neckington.Migrations;
using System.Reflection.Metadata.Ecma335;

namespace Neckington.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        public ContactsController(
            CreateContactUseCases contactUseCases, GetallContacts getAllContacts,
           DeleteContactsByEmail deleteContactsByEmail, UpdateContactsById updateContactsByEmails)
        {
            _contactUseCases = contactUseCases;
            _getall = getAllContacts;
            _deleteContact = deleteContactsByEmail;
            _updateContact = updateContactsByEmails;
        }

        [HttpGet("GetContacts")]
        public async Task<IActionResult> GetallContact()
        {
            var Contactasd = await _getall.GetAllContacts();
            return Ok(Contactasd);
        }

        [HttpPost("CreateContact")]
        public async Task<IActionResult> CreateAction([FromBody] ContactDTO contact)
        {
            var returnsmh = await _contactUseCases.ContactCreate(contact);
            return Ok(returnsmh);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateContact(int Id)
        {
           await _updateContact.ExecuteContactUpdate(Id);
           return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int Id)
        {
            await _deleteContact.GiveContactToDelete(Id);
            return NoContent();
        }
       
        private readonly CreateContactUseCases _contactUseCases;
        private readonly GetallContacts _getall;
        private readonly DeleteContactsByEmail _deleteContact;
        private readonly UpdateContactsById _updateContact;
    }
}
   



    
    


