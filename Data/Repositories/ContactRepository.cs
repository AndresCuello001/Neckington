using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Neckington.Core.Factory;
using Neckington.Core.Interfaces;
using Neckington.DTOs;
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
        public void Add(Contact contact)
        {
           _context.Add(contact);
           _context.SaveChanges();
        }
        public Contact GetByEmail(string email)
        {
          var result = _context.Contact.Single(c => c.UserEmail == email);
          
          return result;
        
        }
        public void Update(Contact contactUpdated)
        {
            _context.Update(contactUpdated);
            _context.SaveChanges();
        }

        
        public List<Contact> GetAll()
        {
            return _context.Contact.ToList();   
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        private readonly ContactDbContext _context;
    }
}
