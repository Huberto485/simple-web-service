using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppService.Services;
using WebAppService.Models;

namespace WebAppService.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        public UsersController(JsonFileUserService userService)
        {
            this.UserService = userService;
        }

        public JsonFileUserService UserService { get;  }

        public IEnumerable<User> Get()
        {
            return UserService.GetUsers();
        }

        [Route("Delete")]
        [HttpGet]
        public ActionResult Get([FromQuery] string userId)
        {
            UserService.DeleteUser(userId);
            return Ok();
        }

        [Route("Create")]
        [HttpGet]
        public ActionResult Get([FromQuery] string userName,
            [FromQuery] string userEmail,
            [FromQuery] string userTelephone)
        {
            UserService.AddUser(userName, userEmail, userTelephone);
            return Ok();
        }

        [Route("Update")]
        [HttpGet]
        public ActionResult Get([FromQuery] string userId, 
            [FromQuery] string userName, 
            [FromQuery] string userEmail, 
            [FromQuery] string userTelephone)
        {
            UserService.UpdateUser(userId, userName, userEmail, userTelephone);
            return Ok();
        }
    }
}