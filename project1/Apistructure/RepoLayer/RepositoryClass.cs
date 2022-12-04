using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepositoryClass
    {
        List<User> UserList();
    }

    public class RepositoryClass : IRepositoryClass
    {
        public List<User> UserList()
        {
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText("UserList.json"))!;
        }
    }
    
}