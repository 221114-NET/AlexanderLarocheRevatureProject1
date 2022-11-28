using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public class RepositoryClass
    {
        public Employee PostEmployeeController(Employee e)
        {
            e.lName = "Jackson";

            List<Employee> elist = new List<Employee>();

            elist.Add(e);

            string eliststr = JsonSerializer.Serialize(elist);

            File.WriteAllText("EmployeeList.json", eliststr);

            return e;

        }
    }
}