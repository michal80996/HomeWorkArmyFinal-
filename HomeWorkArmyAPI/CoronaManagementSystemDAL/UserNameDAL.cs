using CoronaManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaManagementSystemDAL
{
    public class UserNameDAL
    {
        CoronaManagementSystemContext _context = new CoronaManagementSystemContext();
        CoronaDetailsDAL _UserNameDAL = new CoronaDetailsDAL();
        public List<UserName> GetAllUserNames()
        {
            try
            {
                return _context.UserName.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserName GetUserById(string id)
        {
            try
            {
                return _context.UserName.SingleOrDefault(x => x.PersonId.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleatUserName(string PersonId)
        {
            try
            {
                UserName forDelete = _context.UserName.SingleOrDefault(x => PersonId.Equals(x.PersonId));
                _context.UserName.Remove(forDelete);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUserName(UserName newUserName)
        {
            try
            {
                _context.UserName.Add(newUserName);
                _UserNameDAL.AddUserNameDetails(newUserName.PersonId);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool UpdateFlightDetails(String id, UserName userName)
        {
            try
            {
                UserName currentUserName = _context.UserName.SingleOrDefault(x => x.PersonId == id);
                _context.Entry(currentUserName).CurrentValues.SetValues(userName);
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
