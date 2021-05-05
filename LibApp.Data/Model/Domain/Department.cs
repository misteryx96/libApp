using System.Collections.Generic;

namespace LibApp.Data.Model.Domain
{
    public class Department
    {
        public Department()
        {
            Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
