using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2.Repository
{
    class Repository<T> : IRepository<T> where T : class
    {
        public List<T> list;

        public Repository() {
            list = new List<T>();
        }

        public bool Add(T Entity)
        {
            try
            {
                list.Add(Entity);
                return true;
            } catch (Exception)
            {
                return false;
            }           
        }

        public bool Delete(object id)
        {
            try
            {
                T entity = GetById(id);
                list.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            return list.Find((Predicate<T>)id);
        }

        public bool Update(T Entity)
        {
            try
            {

                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
