using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Models;

namespace Neckington.Core.Factory
{
    public class Class1
    {
        public Contact GetCreateContactDtoFactory() 
        {
            return new Contact();
        }
    }
}
