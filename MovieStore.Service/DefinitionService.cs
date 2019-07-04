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
    public class DefinitionService : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
      public List<GenreDTO> GetGenres()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var genres = uow.Genres.List();
                List<GenreDTO> list = new List<GenreDTO>();
                foreach (var item in genres)
                {
                    list.Add(Mapper.Map<Genre, GenreDTO>(item));
                }
                return list;                
            }
        }
        public List<RecordStatusDTO> GetRecordStatus()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var recordstatuses = uow.RecordStatuses.List();
                List<RecordStatusDTO> list = new List<RecordStatusDTO>();
                foreach (var item in recordstatuses)
                {
                    list.Add(Mapper.Map<RecordStatus, RecordStatusDTO>(item));
                }
                return list;
            }
        }
    }
}
