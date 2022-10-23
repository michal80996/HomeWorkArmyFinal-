using System;
using System.Collections.Generic;

namespace CoronaManagementSystemDAL.Models
{
    public partial class UserName
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        // public byte[] MyImage { get; set; }
        public virtual CoronaDetails CoronaDetails { get; set; }
    }
}
