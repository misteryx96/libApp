using System;
using System.Collections.Generic;

namespace LibApp.Data.Model.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
