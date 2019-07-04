using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class CustomerDTO:IEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNumber { get; set; }
        public string MobilePhone { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public string RecordStatusName { get; set; }
    }
}
