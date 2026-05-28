using Neckington;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Neckington.Core.Base;
using Neckington.Core.Configuration;
using Neckington.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Neckington.Models
{
    public class Contact 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public long PhoneNumber { get; set; }
        public long WorkNumber { get; set; }
        public string? Address { get; set; }
      
       // [ForeignKey]
       // public int CategoryId { get; set;}
        // public static int counter = 1;
    }
}
