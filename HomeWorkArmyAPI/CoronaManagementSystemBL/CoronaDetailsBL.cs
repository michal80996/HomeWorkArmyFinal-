using AutoMapper;
using CoronaManagementSystemDTO;
using System;
using System.Collections.Generic;
using CoronaManagementSystemDAL;
using CoronaManagementSystemDAL.Models;

namespace CoronaManagementSystemBL
{
    public class CoronaDetailsBL
    {
        IMapper mapper;
        public CoronaDetailsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        private CoronaDetailsDAL _CoronaDetailsDAL = new CoronaDetailsDAL();
        public List<CoronaDetailsDTO> GetAllCoronaDetials()
        {
            List<CoronaDetails> allCoronaDetails = _CoronaDetailsDAL.GetAllCoronaDetials();
            return mapper.Map<List<CoronaDetails>, List<CoronaDetailsDTO>>(allCoronaDetails);
        }
        public bool UpdateCoronaDetails(string PersonId, CoronaDetailsDTO theUserName)
        {
            return _CoronaDetailsDAL.UpdateCoronaDetails(PersonId, mapper.Map<CoronaDetailsDTO, CoronaDetails>(theUserName));
        }
    }
}
