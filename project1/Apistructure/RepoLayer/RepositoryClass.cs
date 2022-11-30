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
        public User PostUserController(User u)
        {
        
            u.Lname = "Jackson";

            List<User> ulist = new List<User>();

            ulist.Add(u);

            string uliststr = JsonSerializer.Serialize(ulist);

            File.WriteAllText("UserList.json", uliststr);

            return u;

        }
    }
}