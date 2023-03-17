using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsL1.Interface
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Add(T entity);
        void Save();
    }
}
