using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Core.Interfaces
{
    public interface IModifyActions<T>
    {
        void Update(T entity);
        public void Delete(T entity);
    }
}
