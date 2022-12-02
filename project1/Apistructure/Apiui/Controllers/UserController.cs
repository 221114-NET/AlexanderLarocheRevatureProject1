using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace Apiui.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ITicketRequest _itr;
        public UserController(ITicketRequest itr) => this._itr = itr;

        [HttpPost("UserRegistration")]
        public ActionResult<User> UserRegistration(string username, string email, string password)
        {
            User u1 = _itr.UserRegistration(username, email, password);
            return Created("mydb/user/registration", u1);
        }

        [HttpGet("UserLogin")]
        public ActionResult<User> UserLogin(string username, string password)
        {
            User u2 = _itr.UserLogin(username, password);
            return Created("mydb/user/login", u2);
        }
        
        [HttpPost("AdminLogin")]
        public ActionResult<User> AdminLogin(string username, string password)
        {
            User u1 = _itr.UserLogin(username, password);
            return Created("mydb/user/login", u1);
        }

    }
}