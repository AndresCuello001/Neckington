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
        public void Create(T entity);
        public List<T> GetAll();

    //   public void asd(T entity);
    
    }
}
