using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoronaManagementSystemBL;
using CoronaManagementSystemDTO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WEBCoronaManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserNameController : Controller
    {
        private IUserNameBL _UserNameBL;

        public UserNameController(IUserNameBL userNameBL)
        {
            _UserNameBL = userNameBL;
        }

        [HttpGet]
        [Route("GetAllUserName")]
        public JsonResult GetAllUserName()
        {
            try
            {
                return new JsonResult (_UserNameBL.GetAllUserName().ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("getUserById/{id}")]
        public JsonResult GetUserById(string id)
        {
            try
            {
                return new JsonResult(_UserNameBL.GetUserById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateUserName/{personId}")]
        public IActionResult UpdateUserName(String personId, [FromBody] UserNameDTO theUserName)
        {
            var updateUser= _UserNameBL.UpdateUserName(personId, theUserName);
            return Ok(updateUser);
        }

        //[HttpPut]
        //[Route("uploadFile")]
        //public IActionResult uploadFile( byte[] image, string id)
        //{
        //    try
        //    {
        //       return Ok(_UserNameBL.uploadFile(image, id));
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        [HttpPost]
        [Route("AddUserName")]
        public IActionResult AddUserName([FromBody] UserNameDTO NewUserName)
        {
            var addUser= _UserNameBL.AddUserName(NewUserName);
            return Ok(addUser);
        }

        [HttpDelete]
        [Route("DeleteUserName/{personId}")]
        public bool DeleteUserName( string personId)
        {  
            return _UserNameBL.DeleatUserName(personId);
        }
    }
}
