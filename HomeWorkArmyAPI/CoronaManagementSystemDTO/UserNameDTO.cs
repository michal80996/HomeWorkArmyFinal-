using System;

namespace CoronaManagementSystemDTO
{
    public class UserNameDTO
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
       // public byte[] MyImage { get; set; }
    }
}
