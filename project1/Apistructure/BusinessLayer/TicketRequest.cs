using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
public interface ITicketRequest
{
    public User UserRegistration(string username, string email, string password);
    public User UserLogin(string email, string password);
    public User AdminLogin(string email, string password);
}


    public class TicketRequest : ITicketRequest
    {
       
        private readonly IRepositoryClass _irc;
        public TicketRequest(IRepositoryClass irc) => this._irc = irc;

        public User UserRegistration (string username, string email, string password)
        {
        List<User> UserInfo = _irc.UserList();
        return null!;//need to change this to an actual value
        }

    }
}