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
    public class EmployeeController : ControllerBase
    {
        private readonly BusinessLayerClass _buslayer = new BusinessLayerClass();

        [HttpPost("reimbursementportal")]
        public ActionResult<Employee> PostEmployeeController(Employee e)
        {
            e.fName = "Antoine";
            Employee emp1 = _buslayer.PostEmployeeController(e);

            return Created("mydb/employee/here", emp1);

            
        }

    }
}