using EmployeeManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Common.DataProvider
{
	public interface IEmployeeDataProvider
	{
		IEnumerable<Employee> LoadEmployees();
		void SaveEmployee(Employee employee);
		IEnumerable<JobRole> LoadJobRoles();

	}
}
