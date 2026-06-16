using Neckington.Domain.Entities;
using Neckington.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.Mappers
{
    public static class ContactMapper
    {
        public static Contact ToEntity(RegisterContactDTO contactDto) {

            return new Contact
            {
                Id = contactDto.Id,
                FirstName = contactDto.FirstName,
                LastName = contactDto.LastName,
                PhoneNumber = contactDto.PhoneNumber,
                WorkNumber = contactDto.WorkNumber,
                Address = contactDto.Address,
                DateOfBirth = contactDto.DateOfBirth,
            };
        
        }

       /* public static Contact ShowContact(List<Contact> contactDto) 
        {
            return new ShowContactDTOless
            {
                FirstName = contactDto.FirstName,
                PhoneNumber = contactDto.PhoneNumber,
                WorkNumber = contactDto.WorkNumber,
                Address = contactDto.Address

            };        
        }*/
    }
}
