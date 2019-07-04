using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class RentalDTO:IEntity
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public string CustomerName { get; set; }
        public string MovieName { get; set; }
        public string RecordStatusName { get; set; }
        public string CreatedByName { get; set; }
    }
}
