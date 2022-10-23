using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoronaManagementSystemBL;
using CoronaManagementSystemDTO;
using System.Collections.Generic;
using System;

namespace WEBCoronaManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserNameController : Controller
    {
       private UserNameBL _UserNameBL = new UserNameBL();
       
        [HttpGet]
        [Route("GetAllUserName")]
        public IActionResult GetAllUserName()
        {
            try
            {
                return Ok(_UserNameBL.GetAllUserName().ToArray());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("getUserById/{id}")]
        public IActionResult GetUserById(string id)
        {
            try
            {
                return Ok(_UserNameBL.GetUserById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateUserName/{personId}")]
        public bool UpdateUserName(String personId, [FromBody] UserNameDTO theUserName)
        {
            return _UserNameBL.UpdateUserName(personId, theUserName);
        }

        [HttpPost]
        [Route("AddUserName")]
        public bool AddUserName(UserNameDTO NewUserName)
        {
            return _UserNameBL.AddFlight(NewUserName);
        }

        [HttpDelete]
        [Route("DeleteUserName")]
        public bool DeleteUserName( string personId)
        {  
            return _UserNameBL.DeleatUserName(personId);
        }
    }
}
