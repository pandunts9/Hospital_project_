using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class Admin : User
    {
        public static Admin Administrator;
        public int Salary { get; set; }
        public Admin() : base()
        {
        }
        public Admin(string name, string lastname, string phone, int year, int month, int day, Gender gender,
            string address, string username, string password, int salary) : base(name, lastname, phone,
                year, month, day, gender, address, username, password)
        {
            this.isAdmin = true;
            this.Salary = salary;
        }
        
    }
}
