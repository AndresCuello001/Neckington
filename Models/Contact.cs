using Neckington.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Models
{
    public class Contact
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public int Age {get; set;} 
        public long Number { get; set;}
    }
}
