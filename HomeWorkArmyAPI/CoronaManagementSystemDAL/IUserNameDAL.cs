using CoronaManagementSystemDAL.Models;
using System.Collections.Generic;

namespace CoronaManagementSystemDAL
{
    public interface IUserNameDAL
    {
        UserName AddUserName(UserName newUserName);
        bool DeleatUserName(string PersonId);
        List<UserName> GetAllUserNames();
        UserName GetUserById(string id);
        UserName UpdateUserName(string id, UserName userName);
        //bool uploadFile(byte[] image, string id);
    }
}