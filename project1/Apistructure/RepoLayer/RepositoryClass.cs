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
        void PostUsers(List<User> allUsers);
    }

    public class RepositoryClass : IRepositoryClass
    {
        public List<User> UserList()
        {
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText("UserList.json"))!;
        }

        public void PostUsers(List<User> allUsers){
            string userserialization = JsonSerializer.Serialize(allUsers);
            File.WriteAllText("AllUsers.json", userserialization);
        }

    public interface IRepositoryClass2 {
        List<Reimbursement> TicketList();
        void PostReimbursements(List<Reimbursement> allReimbursements);
        }

        public class RepositoryClass2 : IRepositoryClass2 {
            public List<Reimbursement> TicketList() {
            return JsonSerializer.Deserialize<List<Reimbursement>>(File.ReadAllText("AllTickets.json"))!;
        }

        public void PostReimbursements(List<Reimbursement> allReimb) {
            string reimbserialization = JsonSerializer.Serialize(allReimb);
            File.WriteAllText("AllReimb.json", reimbserialization);
        }

    }
    }  
}