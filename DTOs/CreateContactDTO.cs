using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.DTOs
{
    public class CreateContactDTO
    {
       public int Id { get; set; }
       public string? FirstName { get; set; }
       public string? LastName { get; set; }
       public DateTime? DateOfBirth { get; set; }
       public string? UserEmail { get; set; }
       public long PhoneNumber { get; set; }
       public long WorkNumber { get; set; }
       public string? Address { get; set; }
    }
}
