using Neckington.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Data.Repositories
{
    public class ContactRepository<Contact> : IRegisterRepository<Contact> , IModifyActions<Contact>
    {
        public ContactRepository(AppDbContext context)
        { 
             _context = context;
        }
        
        public void Create(Contact contact)
        {

            _context.Add(contact);
            _context.SaveChanges();

        }


        


       private readonly AppDbContext _context;
    }
}
