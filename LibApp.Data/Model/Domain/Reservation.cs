﻿using System;
using System.Collections.Generic;

namespace LibApp.Data.Model.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public DateTime? ReservedDateTime { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? TookDateTime { get; set; }
        public DateTime? ReturnDateTime { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
        public int LibrarianId { get; set; }
        public User Librarian { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
