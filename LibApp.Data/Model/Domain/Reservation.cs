using System;
using System.Collections.Generic;
using System.Text;

namespace LibApp.Data.Model.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? TookDateTime { get; set; }
        public DateTime? ReturnDateTime { get; set; }
        //TODO: UserId
        public int UserId { get; set; }
        public int LibrarianId { get; set; }
    }
}
