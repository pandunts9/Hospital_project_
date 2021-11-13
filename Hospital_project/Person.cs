using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class Person
    {
        public Guid Id { get; } = new Guid();
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, string lastname, string phone, string address, int year, int month, int day, Gender gender)
        {
            Name = name;
            LastName = lastname;
            Phone = phone;
            Address = address;
            string date = String.Format($"{year}/{month}/{day}");
            DateOfBirth = DateTime.Parse(date);
            this.Gender = gender;
        }
        public Person()
        {
           
        }
    }
    public enum Gender
    {
        male,
        female
    }
}
