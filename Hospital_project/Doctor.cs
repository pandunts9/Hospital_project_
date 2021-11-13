using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class Doctor : User
    {
        public string Specialization { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string Bio { get; set; }
        public bool isFired { get; set; }
        public int WorkplaceId { get; set; }
        public bool IsOnDuty { get; set; }
        public int Rating { get; set; }
        public List<int> Clients;

        public override string NameLastname
        {
            get
            {
                return this.Name + " " + this.LastName;
            }
        }

        public Doctor(string name, string lastname, string phone, int year, int month, int day, Gender gender, string address, string username,
            string password, string bio, string department, string specialization, int salary, int workplaceId) :
            base(name, lastname, phone, year, month, day, gender, address, username, password)
        {
            this.Specialization = specialization;
            this.Department = department;
            this.Salary = salary;
            this.Bio = bio;
            this.WorkplaceId = workplaceId;
            this.Clients = new List<int>();
        }

        public override string ToString()
        {
            string about = "";
            about += "Name : " + this.Name +
                "\nLastname : " + this.LastName +
                "\nSpecification : " + this.Specialization +
                "\nGender : " + this.Gender +
                "\nDate of birdth : " + this.DateOfBirth.ToShortDateString() +
                "\nAddress : " + this.Address +
                "\nPhone : " + this.Phone +
                "\n---------------------------------------\nBio :\n " + this.Bio;
            return about;
        }
    }
}
