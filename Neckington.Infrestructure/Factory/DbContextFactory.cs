using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Configuration;
using Neckington.Data;

namespace Neckington.Infrastructure.Factory
{
   public class DbContextFactory : IDesignTimeDbContextFactory<ContactDbContext>
   {
        public ContactDbContext CreateDbContext(string[] args)
        {
             var optionsBuilder = new DbContextOptionsBuilder<ContactDbContext>();

                     optionsBuilder.UseSqlServer(Constants.ConnectionString);

                         return new ContactDbContext(optionsBuilder.Options);
        }
   }  
}
