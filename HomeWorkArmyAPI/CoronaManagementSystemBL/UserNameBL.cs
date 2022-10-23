using AutoMapper;
using CoronaManagementSystemDTO;
using System;
using System.Collections.Generic;
using CoronaManagementSystemDAL;
using CoronaManagementSystemDAL.Models;


namespace CoronaManagementSystemBL
{
    public class UserNameBL
    {
        IMapper mapper;
        public UserNameBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        private UserNameDAL _userNameDAL = new UserNameDAL();
        public List<UserNameDTO> GetAllUserName()
        {
            List<UserName> allUserName = _userNameDAL.GetAllUserNames();
            return mapper.Map<List<UserName>, List<UserNameDTO>>(allUserName);
        }

        public UserNameDTO GetUserById(string id)
        {
            UserName currentUser=_userNameDAL.GetUserById(id);
            return mapper.Map<UserName, UserNameDTO>(currentUser);
        }

        public bool DeleatUserName(string personId)
        {
            return _userNameDAL.DeleatUserName(personId);
        }

        public bool AddFlight(UserNameDTO NewUserName)
        {
            return _userNameDAL.AddUserName(mapper.Map<UserNameDTO, UserName>(NewUserName));
        }


        public bool UpdateUserName(string PersonId, UserNameDTO theUserName)
        {
            return _userNameDAL.UpdateFlightDetails(PersonId, mapper.Map<UserNameDTO, UserName>(theUserName));
        }
    }
}
