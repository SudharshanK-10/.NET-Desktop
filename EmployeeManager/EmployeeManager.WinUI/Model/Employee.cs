using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WinUI.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsDeveloper { get; set; }  

        public Employee(int Id, string FirstName, string LastName, bool isDeveloper)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsDeveloper = isDeveloper;
        }
    }
}
