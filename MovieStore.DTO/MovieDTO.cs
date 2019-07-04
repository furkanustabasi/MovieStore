using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class MovieDTO:IEntity
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public byte GenreId { get; set; }
        public string DirectorName { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public Nullable<byte> ImdbScore { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }


        public string GenreName { get; set; }
        public string RecordStatusName { get; set; }

        public List<MovieActorDTO> ActorList { get; set; }

        public int ReleaseYear { get; set; }



    }
}
