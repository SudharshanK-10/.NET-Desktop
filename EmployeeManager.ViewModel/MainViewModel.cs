using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModel
{
	public class MainViewModel : ViewModelBase
	{
		private EmployeeViewModel selectedEmployee;
		private readonly IEmployeeDataProvider employeeDataProvider;
		
		public MainViewModel(IEmployeeDataProvider employeeDataProvider)
        {
			this.employeeDataProvider = employeeDataProvider;
		}

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
		public ObservableCollection<JobRole> JobRoles { get; } = new();

		public EmployeeViewModel SelectedEmployee
		{
			get => this.selectedEmployee;
			set
			{
				if (value != this.selectedEmployee)
				{
					this.selectedEmployee = value;
					RaisePropertyChanged();
					RaisePropertyChanged(nameof(IsEmployeeSelected));
				}
			}
		}

		public bool IsEmployeeSelected => SelectedEmployee != null;

		public void Load()
		{
			var employees = this.employeeDataProvider.LoadEmployees();
			var jobRoles = this.employeeDataProvider.LoadJobRoles();

			Employees.Clear();
			foreach(var employee in employees)
			{
				Employees.Add(new EmployeeViewModel(employee, this.employeeDataProvider));
			}

			JobRoles.Clear();
			foreach (var jobRole in jobRoles)
			{
				JobRoles.Add(jobRole);
			}
		}
	}
}
