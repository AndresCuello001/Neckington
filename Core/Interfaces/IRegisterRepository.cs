using Neckington.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Interfaces
{
    public interface IRegisterRepository<T>
    {
        public void Add(T entity);
        public List<T> GetAll();
        public T GetByEmail(string email);

    }
}
