using System;
using System.Collections.Generic;
using System.Text;

namespace LibApp.Data.Model.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        //TODO: EF Joint table or not?
    }
}
