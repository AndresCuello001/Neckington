using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Models; 
namespace Neckington.DTO
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }

       
        public static ContactDTO MapToDTO(Contact contact)
        {
            return new ContactDTO
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                UserEmail = contact.UserEmail
            };
        }
    }
}
