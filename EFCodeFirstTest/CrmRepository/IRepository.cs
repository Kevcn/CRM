using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Find(int id);

        void Add(T entity);

        void Update(T entity, int id);

        void Delete(int id);

    }
}
