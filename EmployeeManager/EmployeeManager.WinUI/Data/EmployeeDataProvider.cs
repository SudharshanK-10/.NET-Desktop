using EmployeeManager.WinUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WinUI.Data
{
	public class EmployeeDataProvider : IEmployeeDataProvider
	{
		public async Task<IEnumerable<Employee>?> GetAllAsync()
		{	
			// use a webAPI or datastore
			await Task.Delay(100);

			return new List<Employee>
			{
				new Employee(1000, "Sudharshan", "Kugan", true),
				new Employee(1001, "Bharath", "Mohan", false),
				new Employee(1002, "Bogar", "Ranganathan", true)
			};
		}
	}
}
