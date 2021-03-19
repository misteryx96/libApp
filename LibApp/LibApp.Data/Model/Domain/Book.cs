using System;

namespace LibApp.Data.Model.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        //TODO: Prolly needs table
        public string Category { get; set; }
        public string Edition { get; set; }
        public Department Department;
        public int DepartmentId { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsReserved { get; set; }
        //TODO: Consider if needed
        public bool IsDeleted { get; set; }
    }
}
