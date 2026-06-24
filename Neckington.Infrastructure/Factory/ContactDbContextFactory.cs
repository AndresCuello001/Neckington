using Neckington.Infrastructure.Configuration;
using Neckington.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Infrastructure.Factory
{
    public static class ContactDbContextFactory
    {
        public static ContactDbContext Create() 
        {
            var options = DatabaseConfig.GetOptions();
            return new ContactDbContext(options);
        }
    }
}
