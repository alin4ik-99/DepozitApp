using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Create(T entity);

        T Get(int id);

        void Delete(T entity);
    }
}
