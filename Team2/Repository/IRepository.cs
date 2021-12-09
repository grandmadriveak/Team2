using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2.Repository
{
    interface IRepository<T> where T : class
    {
        List<T> Get();
        bool Add(T Entity);
        bool Update(T Entity);
        bool Delete(object id);
        T GetById(object id);
    }
}
