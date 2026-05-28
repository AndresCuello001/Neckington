using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Configuration;

namespace Neckington.Data
{
   public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
   {
        public AppDbContext CreateDbContext(string[] args)
        {
             var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

                     optionsBuilder.UseSqlServer(Constants.ConnectionString);

                         return new AppDbContext(optionsBuilder.Options);
        }
   }  
}
