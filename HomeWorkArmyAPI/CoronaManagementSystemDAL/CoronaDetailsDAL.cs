using CoronaManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaManagementSystemDAL
{
    public class CoronaDetailsDAL
    {
        CoronaManagementSystemContext _context = new CoronaManagementSystemContext();
        public List<CoronaDetails> GetAllCoronaDetials()
        {
            try
            {
                return _context.CoronaDetails.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUserNameDetails(string PersonId)
        {
            try
            {
                CoronaDetails NewUserNameDetials=new CoronaDetails(PersonId);

                _context.CoronaDetails.Add(NewUserNameDetials);
                
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool UpdateCoronaDetails(String id, CoronaDetails userNameCoronaDetials)
        {
            try
            {
                CoronaDetails currentUserName = _context.CoronaDetails.SingleOrDefault(x => x.PersonId == id);
                _context.Entry(currentUserName).CurrentValues.SetValues(userNameCoronaDetials);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
