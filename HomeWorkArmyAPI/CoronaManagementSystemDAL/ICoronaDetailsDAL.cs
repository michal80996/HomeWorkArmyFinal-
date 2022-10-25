using CoronaManagementSystemDAL.Models;
using System.Collections.Generic;

namespace CoronaManagementSystemDAL
{
    public interface ICoronaDetailsDAL
    {
        bool AddUserNameDetails(string PersonId);
        List<CoronaDetails> GetAllCoronaDetials();
        CoronaDetails getCoronaDetailById(string id);
        CoronaDetails UpdateCoronaDetails(string id, CoronaDetails userNameCoronaDetials);
        public int[] numberOfVaccinatorsInMonth();
    }
}