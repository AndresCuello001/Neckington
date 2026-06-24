
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Application.DTOs
{
    public class ContactDTO
    {
       public int Id { get; set; }
       public string? FirstName { get; set; }
       public string? LastName { get; set; }
       public DateTime? DateOfBirth { get; set; }
       public string? UserEmail { get; set; }
       public string? PhoneNumber { get; set; }
       public string? WorkNumber { get; set; }
       public string? Address { get; set; }

    }

    public class ShowContactDTOless 
    {
        public string? FirstName { get; set; }
        public string? UserEmail { get; set; }
        public long PhoneNumber { get; set; }
        public long WorkNumber { get; set; }
        public string? Address { get; set; }

    }

}
