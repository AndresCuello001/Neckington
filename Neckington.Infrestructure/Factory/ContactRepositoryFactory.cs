using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Data.Repositories;
using Neckington.Data;
using Neckington.Domain.Entities;
using Neckington.Core.Configuration;

namespace Neckington.Infrastructure.Factory
{
    public static class CreateContactDtoRepositoryFactory
    {
        public static ContactRepository<Contact> CreateContactRepository() 
        {
            var options = DatabaseConfig.GetOptions();
            var context = ContactDbContextFactory.Create();

            return new ContactRepository<Contact>(context);
        }
    }
}
