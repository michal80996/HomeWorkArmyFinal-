using System;
using System.Collections.Generic;

namespace CoronaManagementSystemDAL.Models
{
    public partial class CoronaDetails
    {
        public string PersonId { get; set; }
        public DateTime? CoronaVaccine { get; set; }
        public string CoronaManufacturer { get; set; }
        public DateTime? PositiveForCorona { get; set; }
        public DateTime? RecoveringFromCorona { get; set; }

        public virtual UserName Person { get; set; }

        public CoronaDetails(string personId)
        {
            PersonId = personId;
        }
    }
}
