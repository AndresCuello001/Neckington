using Neckington.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Domain.Interfaces
{
    public interface IRegisterRepository<T>
    {
        Task AddAsync(T entity);
       Task<List<T>> GetAllAsync();
        Task <T> GetByEmailAsync(string email);
    }
}
