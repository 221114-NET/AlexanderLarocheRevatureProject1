using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class User
    {
        public User(int UserId, string username, string password, string Fname, string Lname, string email, int role)
        {
            this.UserId = UserId;
            this.username = username;
            this.password = password;
            this.Fname = Fname;
            this.Lname = Lname;
            this.email = email;
            this.role = role;
        }

        public int UserId {get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string email { get; set; }
        public int role {get; set; }
    }

    public class Reimbursement
    {
            public Reimbursement(int ReimbursementId, int author, int amount, int DateSubmitted, int DateResolved, string description, int status, int type)
            {
                this.ReimbursementId = ReimbursementId;
                this.author = author;
                this.amount = amount;
                this.DateSubmitted = DateSubmitted; // get rid of
                this.DateResolved = DateResolved;// get rid of
                this.description = description; // get rid of
                this.status = status;
                this.type = type;
            }

            public int ReimbursementId {get; set; }
            public int author {get; set; }
            public int amount {get; set; }
            public int DateSubmitted {get; set; }
            public int DateResolved {get; set; }
            public string description {get; set; }
            public int status {get; set; }
            public int type {get; set; }
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

    public class ReimbursementType //possibly shows what reimbursement is for (travel, gas, etc)
    {
        public ReimbursementType(int TypeId, string Rtype)
        {
            this.TypeId = TypeId;
            this.Rtype = Rtype;
        }

        public int TypeId {get; set; }
        public string Rtype {get; set; }
    }
}