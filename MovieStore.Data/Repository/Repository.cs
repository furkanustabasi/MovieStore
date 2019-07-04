using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MovieStoreEntities _db;
        public Repository(MovieStoreEntities db)
        {
            _db = db;
        }

        public T Add(T obj)
        {
            _db.Set<T>().Add(obj);
            return obj;
        }

        public void Delete(T obj)
        {
            _db.Entry<T>(obj).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> List()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public void Update(T obj)
        {
            _db.Entry<T>(obj).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
