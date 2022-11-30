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

        public User PostUserController(User u)
        {
        
        u.UserId = 16;
        User u1 = _repo.PostUserController(u);
        return u1;

        }
    }
}