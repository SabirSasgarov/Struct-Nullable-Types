using Struct_Nullable_Types.Interfaces;
using Struct_Nullable_Types.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Struct_Nullable_Types.Exceptions;

namespace Struct_Nullable_Types.Services
{
	internal class EmployeeService : IEmployeeService
	{
		private static Employee[] Employees = new Employee[0];
		
		public void AddEmployee(Employee employee)
		{
			foreach (Employee emp in Employees) 
			{
				if (employee.Name == emp.Name && employee.Surname == emp.Surname)
					throw new Conflict("Can not add same employee!");
			}
			Array.Resize(ref Employees, Employees.Length+1);
			Employees[^1] = employee;
		}

		public void CheckEmployees(DateTime startDate, DateTime endDate, double minSalary)
		{
			int count = default;
			foreach (var employee in Employees)
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
