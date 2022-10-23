using AutoMapper;
using CoronaManagementSystemDTO;
using System;
using System.Collections.Generic;
using CoronaManagementSystemDAL;
using CoronaManagementSystemDAL.Models;


namespace CoronaManagementSystemBL
{
    public class UserNameBL : IUserNameBL
    {
        IMapper mapper;
        private IUserNameDAL _userNameDAL;

        public UserNameBL(IUserNameDAL userNameDAL)
        {
            this._userNameDAL = userNameDAL;
  
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<UserNameDTO> GetAllUserName()
        {
            List<UserName> allUserName = _userNameDAL.GetAllUserNames();
            return mapper.Map<List<UserName>, List<UserNameDTO>>(allUserName);
        }

        public UserNameDTO GetUserById(string id)
        {
            UserName currentUser = _userNameDAL.GetUserById(id);
            return mapper.Map<UserName, UserNameDTO>(currentUser);
        }

        public bool DeleatUserName(string personId)
        {
            return _userNameDAL.DeleatUserName(personId);
        }

        public UserNameDTO AddUserName(UserNameDTO NewUserName)
        {
            UserName currentUser = _userNameDAL.AddUserName(mapper.Map<UserNameDTO, UserName>(NewUserName));
            return mapper.Map<UserName, UserNameDTO>(currentUser);
        }


        public UserNameDTO UpdateUserName(string PersonId, UserNameDTO theUserName)
        {
            UserName theUser = _userNameDAL.UpdateUserName(PersonId, mapper.Map<UserNameDTO, UserName>(theUserName));
            return mapper.Map<UserName, UserNameDTO>(theUser);
        }

        //public bool uploadFile(byte[] image, string id)
        //{
        //   return _userNameDAL.uploadFile(image, id);
        //}
    }
}
