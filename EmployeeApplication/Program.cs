using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            Employee employee = new Employee();

                employee.FirstName = "Kari";
                employee.LastName = "Lahti";
                employee.Profession = "Janitor";
                employee.Salary = 2500;

                boss.FirstName = "Masi";
                boss.LastName = "Panninen";
                boss.Profession = "Head Janitor";
                boss.Salary = 9500;
                boss.Car = "Audi R8";
                boss.Bonus = 3000;

            Console.WriteLine("\n" + employee.ToString() + "\n");

            Console.WriteLine("\n" + boss.ToString() + "\n");

                employee.FirstName = "Kari";
                employee.LastName = "Lahti";
                employee.Profession = "A bit better Janitor";
                employee.Salary = 3500;

            Console.WriteLine("\n" + employee.ToString() + "\n");
        }
    }
}
