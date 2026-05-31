using Microsoft.EntityFrameworkCore;
using Neckington.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Configuration
{ 
    public static class DatabaseConfig
    {
        public static DbContextOptions<AppDbContext> GetOptions()
        {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseSqlServer(Constants.ConnectionString);
                return optionsBuilder.Options;
        }
    }
}

