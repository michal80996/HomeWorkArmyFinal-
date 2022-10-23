using CoronaManagementSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoronaManagementSystemDAL
{
    public class UserNameDAL : IUserNameDAL
    {
        CoronaManagementSystemContext _context = new CoronaManagementSystemContext();
        CoronaDetailsDAL _CoronaDetailsDAL = new CoronaDetailsDAL();
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

        //public bool uploadFile(byte[] image,string id)
        //{
        //    try
        //    {
        //        UserName userName = _context.UserName.SingleOrDefault(x => x.PersonId.Equals(id));
        //        userName.MyImage = image;
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}


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

        public UserName AddUserName(UserName newUserName)
        {
            try
            {
                _context.UserName.Add(newUserName);
                _context.SaveChanges();
                _CoronaDetailsDAL.AddUserNameDetails(newUserName.PersonId);
                _context.SaveChanges();
                return newUserName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public UserName UpdateUserName(string id, UserName userName)
        {
            try
            {
                UserName currentUserName = _context.UserName.SingleOrDefault(x => x.PersonId == id);
                if (currentUserName != null)
                {
                    _context.Entry(currentUserName).CurrentValues.SetValues(userName);
                    _context.SaveChanges();
                }
                return currentUserName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
