using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Nullable_Types.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }

        public Employee(DateTime bday)
        {
            BirthDate = bday;
        }

        public static void CheckEmployees(Employee[] employees, DateTime startDate, DateTime endDate, double minSalary)
        {
            int count = default;
            foreach (var employee in employees)
            {
                if (employee.BirthDate >= startDate && employee.BirthDate <= endDate && employee.Salary >= minSalary)
                {
                    Console.WriteLine($"{employee.Name} {employee.Surname} meets the criteria.");
                    count++;
                }
            }
            Console.WriteLine(count);
        }


    }
}
