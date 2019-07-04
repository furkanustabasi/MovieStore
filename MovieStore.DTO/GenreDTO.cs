using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class GenreDTO:IEntity
    {
        public byte GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
