using CoronaManagementSystemDTO;
using System.Collections.Generic;

namespace CoronaManagementSystemBL
{
    public interface IUserNameBL
    {
        UserNameDTO AddUserName(UserNameDTO NewUserName);
        bool DeleatUserName(string personId);
        List<UserNameDTO> GetAllUserName();
        UserNameDTO GetUserById(string id);
        UserNameDTO UpdateUserName(string PersonId, UserNameDTO theUserName);
       // bool uploadFile(byte[] image, string id);
    }
}