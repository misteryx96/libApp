using System;
using System.ComponentModel;

namespace LibApp.Data.Model.Domain
{
    //TODO: Maybe user groups
    public enum Role : byte
    {
        [Description("LA_Role_Admin")]
        Admin,
        [Description("LA_Role_Librarian")]
        Librarian,
        [Description("LA_Role_Regular")]
        Regular,
    }
    public class User
    {
        public User()
        {
            CreatedTimeStamp = DateTime.Now;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string CardCode { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
    }
}
