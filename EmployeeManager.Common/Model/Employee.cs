using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Common.Model
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public DateTime EntryDate { get; set; }
		public int JobRoleId { get; set; }
		public bool IsCoffeeDrinker { get; set; }

	}
}
