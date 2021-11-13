using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class Hospital
    {
        public string Name { get; set; }
        private string address;
        public string Address
        {
            get
            { return this.address; }
            set
            {
                this.address = value;
            }
        }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Intro { get; set; }
        public decimal Budget { get; set; }
        public int Percent { get; set; }
        public decimal incomeFromSponsors { get; set; }
        public Hospital(string name, string address, string phone, string email, string intro, decimal budget, decimal income)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.Intro = intro;
            this.Budget = budget;
            this.incomeFromSponsors = income;
        }
        public override string ToString()
        {
            return "Address:  " + this.Address + "\n" +
                   "Phone:    " + this.Phone + "\n" +
                   "Email:    " + this.Email;
        }
    }
}
