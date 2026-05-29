using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Data.Repositories;
using Neckington.Data;
using Neckington.Models;
using Neckington.Core.Configuration;

namespace Neckington.Core.Factory
{
    public static class ContactRepositoryFactory
    {
        public static ContactRepository<Contact> CreateContactRepository() 
        {
            var options = DatabaseConfig.GetOptions();
            var context = AppDbContextFactory.Create();

            return new ContactRepository<Contact>(context);
        }
    
    }
}
