using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class User:Person
    {
        private string username = string.Empty;
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }
        private string password = string.Empty;
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (value.Length < 8 || value.Length > 30)
                {
                    throw new ArgumentException("Password must contain 8-30 characters");
                }
                this.password = value;
            }
        }
        public virtual string NameLastname
        {
            get
            {
                return this.Name + " " + this.LastName;
            }
        }
        public decimal Cash { get; set; }
        public bool isAdmin { get; set; }
        public string History { get; set; }

        public User(string name, string lastname, string phone, int year, int month, int day, Gender gender,
    string address, string username, string password) : base(name, lastname, phone, address, year, month, day, gender)
        {
            this.isAdmin = false;
            this.Username = username;
            this.Password = password;
        }

        public User()
        {
        }
    }
}
