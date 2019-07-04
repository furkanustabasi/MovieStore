using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class MovieActorDTO:IEntity
    {
        public int MovieActorId { get; set; }
        public int MovieId { get; set; }
        public string FullName { get; set; }
    }
}
