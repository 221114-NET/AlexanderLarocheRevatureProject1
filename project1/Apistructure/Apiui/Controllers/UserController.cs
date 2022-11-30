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
        private readonly BusinessLayerClass _buslayer = new BusinessLayerClass();

        [HttpPost("reimbursementportal")]
        public ActionResult<User> PostUserController(User u)
        {
            u.Fname = "Antoine";
            User u1 = _buslayer.PostUserController(u);

            return Created("mydb/user/here", u1);

            
        }

    }
}