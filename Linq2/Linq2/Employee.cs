using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name,string email,double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        
    }
}
