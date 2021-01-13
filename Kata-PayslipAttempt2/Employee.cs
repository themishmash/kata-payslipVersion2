using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Kata_PayslipAttempt2
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        
    }
}