using EmployeeManager.WinUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WinUI.Data
{
    public interface IEmployeeDataProvider
    {
        Task<IEnumerable<Employee>?> GetAllAsync();
    }
}
