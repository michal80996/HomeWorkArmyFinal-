using CoronaManagementSystemBL;
using CoronaManagementSystemDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WEBCoronaManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaDetailsController : ControllerBase
    {
        private ICoronaDetailsBL _coronaDetailsBL;

        public CoronaDetailsController(ICoronaDetailsBL coronaDetailsBL)
        {
            _coronaDetailsBL = coronaDetailsBL;
        }

        [HttpGet]
        [Route("GetAllCoronaDetails")]
        public JsonResult GetAllCoronaDetails()
        {
            try
            {
                return new JsonResult(_coronaDetailsBL.GetAllCoronaDetials().ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        [Route("numberOfVaccinatorsInMonth")]
        public IActionResult numberOfVaccinatorsInMonth()
        {
            try
            {
                return Ok(_coronaDetailsBL.numberOfVaccinatorsInMonth().ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        [Route("getCoronaDetailById/{id}")]
        public JsonResult getCoronaDetailById(string id)
        {
            try
            {
                return new JsonResult(_coronaDetailsBL.getCoronaDetailById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateCoronaDetails/{personId}")]
        public bool UpdateCoronaDetails( String personId,[FromBody] CoronaDetailsDTO theCoronaDetails)
        {
            return _coronaDetailsBL.UpdateCoronaDetails(personId, theCoronaDetails);
        }


    }
}
