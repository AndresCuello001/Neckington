using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Interfaces
{
    interface IContactService
    {
        void AddContact(Contact contact);

        Contact FindByPhone(long phone);

        List<Contact> GetAllContacts();

        void LoadContacts();
    }

}

