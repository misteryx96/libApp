using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LibApp.Data.Model.Domain
{
    [Flags]
    public enum Category : byte
    {
        [Description("LA_Category_Thriller")]
        Thriller,
        [Description("LA_Category_Adventure")]
        Adventure,
        [Description("LA_Category_Comic")]
        Comic,
        [Description("LA_Category_Mistery")]
        Mistery,
        [Description("LA_Category_Fantasy")]
        Fantasy,
        [Description("LA_Category_Fiction")]
        Fiction,
        [Description("LA_Category_Horror")]
        Horror,
        [Description("LA_Category_Romance")]
        Romance,
        [Description("LA_Category_Short")]
        Short,
        [Description("LA_Category_Biography")]
        Biography,
        [Description("LA_Category_Science")]
        Science,
        [Description("LA_Category_Poetry")]
        Poetry,
    }
    public class Book
    {
        public Book()
        {
            CreatedTimeStamp = DateTime.Now;
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public Category? Category { get; set; }
        public string Issue { get; set; }
        public string Edition { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public int? ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime? ModifiedTimestamp { get; set; }
        //TODO: Created/Modified by User
    }
}
