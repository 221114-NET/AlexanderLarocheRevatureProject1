using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Employee
    {
        public Employee(string fName, string lName, int employeeId)
        {
            this.fName = fName;
            this.lName = lName;
            EmployeeId = employeeId;
        }

        public string fName { get; set; }
        public string lName { get; set; }
        public int EmployeeId { get; set; }

    }
}