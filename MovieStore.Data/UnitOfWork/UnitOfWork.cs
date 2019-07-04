using MovieStore.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private MovieStoreEntities db;
        private DbContextTransaction transaction;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UnitOfWork()
        {
            db = new MovieStoreEntities();
        }

        public bool Commit()
        {
            transaction = db.Database.BeginTransaction();
          int affected=  db.SaveChanges();
            transaction.Commit();
            return affected > 0;
        }

        public void RollBack()
        {
            transaction.Rollback();

        }

        public Repository<Customer> Customers { get { return new Repository<Customer>(db); } }
        public Repository<Genre> Genres { get { return new Repository<Genre>(db); } }
        public Repository<MovieActor> MovieActors { get { return new Repository<MovieActor>(db); } }
        public Repository<Movy> Movies { get { return new Repository<Movy>(db); } }
        public Repository<RecordStatus> RecordStatuses { get { return new Repository<RecordStatus>(db); } }
        public Repository<Rental> Rentals { get { return new Repository<Rental>(db); } }
        public Repository<User> Users { get { return new Repository<User>(db); } }
    }
}
