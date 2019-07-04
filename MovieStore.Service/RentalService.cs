using MovieStore.Data;
using MovieStore.Data.UnitOfWork;
using MovieStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Service
{
    public class RentalService : BaseService, IService<RentalDTO>
    {
        public RentalDTO Add(RentalDTO obj)
        {
            using (UnitOfWork uow=new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<RentalDTO, Rental>(obj);
                    entity.RecordStatusId = 1;
                    entity.CreatedDate = DateTime.Now;

                    var rental=uow.Rentals.Add(entity);

                    var movie = uow.Movies.Get(obj.MovieId);
                    movie.Quantity -= 1;
                    uow.Movies.Update(movie);

                    uow.Commit();

                    return Mapper.Map<Rental, RentalDTO>(rental);
                }
                catch (Exception)
                {
                    uow.RollBack();
                    return null;
                }


            }
        }

        public RentalDTO Get(int id)
        {
            using(UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Rentals.Get(id);
                    var rental = Mapper.Map<Rental, RentalDTO>(entity);
                    rental.CustomerName = entity.Customer.FirstName + " " + entity.Customer.LastName;
                    rental.MovieName = entity.Movy.MovieName;
                    rental.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    rental.CreatedByName = entity.User.FirstName + " " + entity.User.LastName;

                    return rental;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public List<RentalDTO> List()
        {
            using (UnitOfWork uow=new UnitOfWork())
            {
                try
                {
                    var entity = uow.Rentals.List();
                    List<RentalDTO> list = new List<RentalDTO>();

                    foreach (var item in entity)
                    {
                        RentalDTO rentalDTO = new RentalDTO
                        {
                            RentalId=item.RentalId,
                            CustomerName=item.Customer.FirstName+ " "+ item.Customer.LastName,
                            MovieName=item.Movy.MovieName,
                            TotalPrice=item.TotalPrice,
                            RecordStatusName=item.RecordStatus.RecordStatusName
                            

                        };
                        list.Add(rentalDTO);
                    }
                    return list;
                }
                catch (Exception)
                {

                    return null;
                }

            }
        }

        public bool Update(RentalDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    if (obj.RecordStatusId==2)
                    {
                       var movie= uow.Movies.Get(obj.MovieId);
                        movie.Quantity += 1;
                        uow.Movies.Update(movie);
                    }
                    
                    var entity = Mapper.Map<RentalDTO, Rental>(obj);
                    uow.Rentals.Update(entity);

                    return uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }

            }
        }
    }
}
