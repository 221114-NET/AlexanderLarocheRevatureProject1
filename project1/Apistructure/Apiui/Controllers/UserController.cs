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

        [HttpPost("ReimbursementPortal")]
        public ActionResult<User> ReimbursementPortal(User u)
        {
            User u1 = _buslayer.ReimbursementPortal(u);
            return Created("mydb/user/portal", u1);
        }

    }
}