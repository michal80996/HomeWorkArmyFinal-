using System;
using System.Collections.Generic;
using System.Text;
using CoronaManagementSystemDAL.Models;

namespace CoronaManagementSystemDTO
{
    public class AutoMapperProfile: AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserNameDTO, UserName>();
            CreateMap<UserName, UserNameDTO>();

            CreateMap<CoronaDetailsDTO, CoronaDetails>();
            CreateMap<CoronaDetails, CoronaDetailsDTO>();        }
    }
}
