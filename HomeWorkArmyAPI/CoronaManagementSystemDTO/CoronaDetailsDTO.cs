using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaManagementSystemDTO
{
    public class CoronaDetailsDTO
    {
        public string PersonId { get; set; }
        public DateTime? CoronaVaccine { get; set; }
        public string CoronaManufacturer { get; set; }
        public DateTime? PositiveForCorona { get; set; }
        public DateTime? RecoveringFromCorona { get; set; }
    }
}
