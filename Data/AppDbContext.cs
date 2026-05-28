using Microsoft.EntityFrameworkCore;
using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Core.Configuration;

namespace Neckington.Data 
{ 
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Constants.ConnectionString);
            }

        }


        public DbSet<Contact> Contact {get; set;}
    }

}




