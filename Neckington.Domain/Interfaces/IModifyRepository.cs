using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Domain.Interfaces
{
    public interface IModifyActions<T>
    {
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
