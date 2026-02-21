using Struct_Nullable_Types.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Nullable_Types.Interfaces
{
	internal interface IEmployeeService
	{
		public void AddEmployee(Employee employee);
		public void CheckEmployees(DateTime startDate, DateTime endDate, double minSalary);

	}
}
