using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
        }

        public override string ToString()
        {
            return " > " + FirstName + " > " + LastName + " > " + Profession + " > " + Salary;
        }
    }
}
