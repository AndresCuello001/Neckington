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
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
            
        }

        public ContactDbContext()
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




