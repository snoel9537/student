using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Inf
{
    public interface IRepository<T>
        where T : class
    {
        IEnumerable<T> FindAll(); 
        T FindById(int id); 
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
