using CoronaManagementSystemDTO;
using System.Collections.Generic;

namespace CoronaManagementSystemBL
{
    public interface ICoronaDetailsBL
    {
        List<CoronaDetailsDTO> GetAllCoronaDetials();
        CoronaDetailsDTO getCoronaDetailById(string id);
        bool UpdateCoronaDetails(string PersonId, CoronaDetailsDTO theUserName);
        public int[] numberOfVaccinatorsInMonth();
    }
}