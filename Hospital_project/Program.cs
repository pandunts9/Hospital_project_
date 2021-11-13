using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital MyHospital = new Hospital("Goris medical center","Grigor Lusavoritch street 25", "+374 0284 2 47 26", "Gorismc@gmail.com",
                "The medical center has been operating since 2021․", 7247259400,25000000);
            
            Person person1 = new Person("Artak", "Grigoryan", "077858595", "Yerevan Mazmanyan 7", 1995, 12, 25, Gender.male);
            Person person2 = new Person("Aram", "Grigoryan", "077858595", "Yerevan Mazmanyan 7", 1995, 12, 25, Gender.male);
        }
    }
}
