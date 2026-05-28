using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Data.Repositories
{
    public interface IReloadActions<T>
    {
        public void Update(T entity);
        public void Delete(T entity);


    }
}
