using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Neckington.Core.Factory;
using Neckington.Core.Interfaces;
using Neckington.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Data.Repositories
{
    public class ContactRepository<T>: IRegisterRepository<Contact> , IModifyActions<Contact>
    {
        public ContactRepository(ContactDbContext context)
        { 
             _context = context;
        }
        public void Create(Contact contact)
        {
           _context.Add(contact);
           _context.SaveChanges();
        }
        public void Update(Contact Contact)
        {
            _context.Contact.Find();
        }
        public List<Contact> GetAll()
        {
            return _context.Contact.ToList();   
        }

        private readonly ContactDbContext _context;

    }
}
