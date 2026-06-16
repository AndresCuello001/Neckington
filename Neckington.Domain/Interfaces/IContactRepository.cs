using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neckington.Domain.Entities;

namespace Neckington.Domain.Interfaces
{
    public interface IContactRepository<T>
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByEmailAsync(string email);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
