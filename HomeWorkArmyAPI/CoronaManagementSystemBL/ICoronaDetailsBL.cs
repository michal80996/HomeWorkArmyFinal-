using CoronaManagementSystemDTO;
using System.Collections.Generic;

namespace CoronaManagementSystemBL
{
    public interface ICoronaDetailsBL
    {
        List<CoronaDetailsDTO> GetAllCoronaDetials();
        CoronaDetailsDTO getCoronaDetailById(string id);
        CoronaDetailsDTO UpdateCoronaDetails(string PersonId, CoronaDetailsDTO theUserName);
        public int[] numberOfVaccinatorsInMonth();
    }
}