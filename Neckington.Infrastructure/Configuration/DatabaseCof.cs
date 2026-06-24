using Microsoft.EntityFrameworkCore;
using Neckington.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Infrastructure.Configuration
{ 
    public static class DatabaseConfig
    {
        public static DbContextOptions<ContactDbContext> GetOptions()
        {
                var optionsBuilder = new DbContextOptionsBuilder<ContactDbContext>();
                optionsBuilder.UseSqlServer(Constants.ConnectionString);
                return optionsBuilder.Options;
        }
    
    }
}

