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
        public IActionResult GetAllUserName()
        {
            try
            {
                return Ok (_UserNameBL.GetAllUserName().ToList());
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
            try
            {
                var updateUser = _UserNameBL.UpdateUserName(personId, theUserName);
                return Ok(updateUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
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
            try 
            { 
                var addUser= _UserNameBL.AddUserName(NewUserName);
                return Ok(addUser);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteUserName/{personId}")]
        public bool DeleteUserName( string personId)
        {
            try
            {
                return _UserNameBL.DeleatUserName(personId);
            }
            catch
            {
                return false;
            }
           
        }
    }
}
