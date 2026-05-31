using Neckington.Models;
using Neckington.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Factory
{
   public static class ContactFactory
   {
        public static Contact Create() 
        {
            return new Contact();
        } 
   }
}
