using AutoMapper;
using CoronaManagementSystemDTO;
using System;
using System.Collections.Generic;
using CoronaManagementSystemDAL;
using CoronaManagementSystemDAL.Models;

namespace CoronaManagementSystemBL
{
    public class CoronaDetailsBL : ICoronaDetailsBL
    {
        IMapper mapper;
        private ICoronaDetailsDAL _CoronaDetailsDAL;
        public CoronaDetailsBL(ICoronaDetailsDAL _CoronaDetailsDAL)
        {
            this._CoronaDetailsDAL = _CoronaDetailsDAL;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        
        public List<CoronaDetailsDTO> GetAllCoronaDetials()
        {
            List<CoronaDetails> allCoronaDetails = _CoronaDetailsDAL.GetAllCoronaDetials();
            return mapper.Map<List<CoronaDetails>, List<CoronaDetailsDTO>>(allCoronaDetails);
        }

        public CoronaDetailsDTO getCoronaDetailById(string id)
        {
            CoronaDetails currentUser = _CoronaDetailsDAL.getCoronaDetailById(id);
            return mapper.Map<CoronaDetails, CoronaDetailsDTO>(currentUser);
        }
        public bool UpdateCoronaDetails(string PersonId, CoronaDetailsDTO theUserName)
        {
            return _CoronaDetailsDAL.UpdateCoronaDetails(PersonId, mapper.Map<CoronaDetailsDTO, CoronaDetails>(theUserName));
        }

        public int[] numberOfVaccinatorsInMonth()
        {
            return _CoronaDetailsDAL.numberOfVaccinatorsInMonth();
        }
    }


}
