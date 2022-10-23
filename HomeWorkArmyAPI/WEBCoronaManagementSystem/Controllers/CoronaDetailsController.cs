using CoronaManagementSystemBL;
using CoronaManagementSystemDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WEBCoronaManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaDetailsController : ControllerBase
    {
        private  CoronaDetailsBL _coronaDetailsBL = new CoronaDetailsBL();

        [HttpGet]
        [Route("GetAllCoronaDetails")]
        public List<CoronaDetailsDTO> GetAllCoronaDetails()
        {
            return _coronaDetailsBL.GetAllCoronaDetials();
        }

        [HttpPut]
        [Route("UpdateCoronaDetails")]
        public bool UpdateCoronaDetails( String personId, CoronaDetailsDTO theCoronaDetails)
        {
            return _coronaDetailsBL.UpdateCoronaDetails(personId, theCoronaDetails);
        }
    }
}
