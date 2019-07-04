using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.Repository
{
   public  interface IRepository<T>:IDisposable where T :class
    {
        List<T> List();
        T Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> Search(Expression<Func<T,bool>> predicate);
        T Get(int id);
    }
}
