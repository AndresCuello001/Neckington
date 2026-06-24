using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Neckington.Infrastructure.Factory;
using Neckington.Domain.Interfaces;
using Neckington.Domain.Entities;
using Neckington.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Infrastructure.Data.Repositories
{
    public class ContactRepository<T>: IContactRepository<Contact>
    {
        public ContactRepository(ContactDbContext context)
        { 
             _context = context;
        }

        public async Task AddAsync(Contact contact)
        {
           await  _context.AddAsync(contact);
           await _context.SaveChangesAsync();
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
          var result = await _context.Contact.SingleAsync(c => c.Id == id);
          
          return result;
        }

        public async Task UpdateAsync(Contact contactUpdated)
        {
            _context.Update(contactUpdated);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _context.Contact.ToListAsync();   
        }

        public async Task DeleteAsync(Contact contact)
        {
            _context.Remove(contact);
           await _context.SaveChangesAsync();
        }
       
        private readonly ContactDbContext _context;
    }
}
