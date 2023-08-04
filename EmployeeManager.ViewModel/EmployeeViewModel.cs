using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System.ComponentModel;

namespace EmployeeManager.ViewModel
{
	public class EmployeeViewModel : ViewModelBase
	{
		private readonly Employee employee;
		private readonly IEmployeeDataProvider employeeDataProvider;

		public EmployeeViewModel(Employee employee, IEmployeeDataProvider employeeDataProvider)
        {
			this.employee = employee;
			this.employeeDataProvider = employeeDataProvider;
		}

		public string FirstName
		{
			get => this.employee.FirstName;
			set 
			{
				if (this.employee.FirstName != value)
				{
					this.employee.FirstName = value;
					RaisePropertyChanged();
					RaisePropertyChanged(nameof(CanSave));
				}
			}
		}

		public DateTime EntryDate
		{
			get => this.employee.EntryDate;
			set
			{
				if (this.employee.EntryDate != value)
				{
					this.employee.EntryDate = value;
					RaisePropertyChanged();
				}
			}
		}

		public int JobRoleId
		{
			get => this.employee.JobRoleId;
			set
			{
				if (this.employee.JobRoleId != value)
				{
					this.employee.JobRoleId = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool IsCoffeeDrinker
		{
			get => this.employee.IsCoffeeDrinker;
			set
			{
				if (this.employee.IsCoffeeDrinker != value)
				{
					this.employee.IsCoffeeDrinker = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool CanSave => !string.IsNullOrEmpty(this.FirstName);

		public void Save()
		{
			this.employeeDataProvider.SaveEmployee(this.employee);
		}
	}
}