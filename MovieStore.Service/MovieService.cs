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
    public class MovieService : BaseService, IService<MovieDTO>
    {
        public MovieDTO Add(MovieDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var enties = Mapper.Map<MovieDTO, Movy>(obj);

                    enties.MovieActors = new List<MovieActor>();

                    foreach (var item in obj.ActorList)
                    {
                        var movieActorEntity = Mapper.Map<MovieActorDTO, MovieActor>(item);

                        enties.MovieActors.Add(movieActorEntity);
                    }

                    var moviesDto = uow.Movies.Add(enties);

                    uow.Commit();

                    return Mapper.Map<Movy, MovieDTO>(moviesDto);

                }
                catch (Exception)
                {
                    uow.RollBack();
                    return null;
                }

            }
        }

        public MovieDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Movies.Get(id);
                    var movie = Mapper.Map<Movy, MovieDTO>(entity);
                    movie.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    movie.GenreName = entity.Genre.GenreName;
                    movie.ActorList = new List<MovieActorDTO>();
                    foreach (var item in entity.MovieActors.ToList())
                    {
                        var actor = Mapper.Map<MovieActor, MovieActorDTO>(item);
                        movie.ActorList.Add(actor);
                    }
                    return movie;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public List<MovieDTO> List()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entities = uow.Movies.List();

                    List<MovieDTO> list = new List<MovieDTO>();

                    foreach (var item in entities)
                    {
                        MovieDTO movieDTO = new MovieDTO
                        {
                            MovieId = item.MovieId,
                            MovieName = item.MovieName,
                            GenreName = item.Genre.GenreName,
                            ReleaseYear = item.ReleaseDate.Year,
                            ImdbScore = item.ImdbScore ?? 0,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice
                        };
                        list.Add(movieDTO);
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public bool Update(MovieDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    if (obj.RecordStatusId ==1)
                    {
                        obj.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        obj.DeletedDate = DateTime.Now;
                    }

                    var entity = Mapper.Map<MovieDTO, Movy>(obj);
                    
                    uow.Movies.Update(entity);
                    uow.Commit();
                    return true;
                    
                }
                catch (Exception)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }
    }
}
