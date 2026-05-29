using Neckington.Core.Configuration;
using Neckington.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Factory
{
    public static class AppDbContextFactory
    {
        public static AppDbContext Create() 
        {
            var options = DatabaseConfig.GetOptions();
            return new AppDbContext(options);
        }
    
    }
}
