using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class User
    {
        public User(int UserId, string username, string email, string password, string Fname, string Lname, int role)
        {
            this.UserId = UserId;
            this.username = username;
            this.email = email;
            this.password = password;
            this.Fname = Fname;
            this.Lname = Lname;
            this.role = role;
        }

        public int UserId {get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int role {get; set; }
    }

    public class Reimbursement
    {
            public Reimbursement(int ReimbursementId, int author, int amount, int DateSubmitted, string description, int status)
            {
                this.ReimbursementId = ReimbursementId;
                this.author = author;
                this.amount = amount;
                this.DateSubmitted = DateSubmitted; // get rid of
                this.description = description; // get rid of
                this.status = status;
            }

            public int ReimbursementId {get; set; }
            public int author {get; set; }
            public int amount {get; set; }
            public int DateSubmitted {get; set; }
            public string description {get; set; }
            public int status {get; set; }
    }

    public class ReimbursementStatus //shows status (pending, approved, denied)
    {
        public ReimbursementStatus(int StatusId, string status)
        {
            this.StatusId = StatusId;
            this.status = status;
        }

        public int StatusId {get; set; }
        public string status {get; set; }
    }
}