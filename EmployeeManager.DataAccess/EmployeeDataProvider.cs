using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.DataAccess
{
	public class EmployeeDataProvider : IEmployeeDataProvider
	{
		public IEnumerable<Employee> LoadEmployees()
		{
			// Can use an external API to fetch data
			return new List<Employee>
			{
				new Employee
				{
					Id = 1,
					FirstName = "ABC",
					EntryDate = new DateTime(2023, 08, 01),
					JobRoleId = 1,
					IsCoffeeDrinker = true
				},
				new Employee
				{
					Id = 2,
					FirstName = "DEF",
					EntryDate = new DateTime(2023, 08, 02),
					JobRoleId = 2,
					IsCoffeeDrinker = false
				}
			};
		} 

		public void SaveEmployee(Employee employee)
		{
			Console.WriteLine($"Employee {employee.Id}, {employee.FirstName} is Saved...");
		}

		public IEnumerable<JobRole> LoadJobRoles()
		{
			return new List<JobRole>
			{
				new JobRole
				{
					Id = 1,
					RoleName = "Software Developer"
				},
				new JobRole
				{
					Id = 2,
					RoleName = "Mainframe Developer"
				}
			};
		}
	}
}
