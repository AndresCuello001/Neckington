using Neckington;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Neckington.Domain.Entities
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
        public string? UserEmail {get; set;}
        public string? PhoneNumber { get; set; }
        public string? WorkNumber { get; set; }
        public string? Address { get; set; }
      
       // [ForeignKey]
       // public int CategoryId { get; set;}
        // public static int counter = 1;
    }
}
