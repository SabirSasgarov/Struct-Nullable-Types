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

    }
}
