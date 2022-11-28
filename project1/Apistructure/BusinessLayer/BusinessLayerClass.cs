using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public class BusinessLayerClass
    {
        private readonly RepositoryClass _repo = new RepositoryClass();

        public Employee PostEmployeeController(Employee e)
        {
        e.EmployeeId = 16;
        Employee emp1 = _repo.PostEmployeeController(e);
        return emp1;
        }
    }
}