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

        public DateTime? CoronaVaccine2 { get; set; }
        public string CoronaManufacturer2 { get; set; }
        public DateTime? CoronaVaccine3 { get; set; }
        public string CoronaManufacturer3 { get; set; }
        public DateTime? CoronaVaccine4 { get; set; }
        public string CoronaManufacturer4 { get; set; }
    }
}
