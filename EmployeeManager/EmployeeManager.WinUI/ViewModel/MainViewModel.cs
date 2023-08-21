using EmployeeManager.WinUI.Command;
using EmployeeManager.WinUI.Data;
using EmployeeManager.WinUI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WinUI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IEmployeeDataProvider employeeDataProvider;
		private EmployeeItemViewModel? selectedEmployee;

		public ObservableCollection<EmployeeItemViewModel> Employees { get; } = new();
		public EmployeeItemViewModel? SelectedEmployee 
        { 
          get => selectedEmployee;
          set 
            { 
                if(selectedEmployee != value) 
                {
				    selectedEmployee = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(IsEmployeeSelected));
                    DeleteCommand.RaiseCanExecuteChanged();
				}
            }
        }

        public bool IsEmployeeSelected => SelectedEmployee is not null;

        public DelegateCommand AddCommand { get; }
		public DelegateCommand DeleteCommand { get; }

		public MainViewModel(IEmployeeDataProvider employeeDataProvider)
        {
			this.employeeDataProvider = employeeDataProvider;
            AddCommand = new DelegateCommand(AddEmployee);
            DeleteCommand = new DelegateCommand(DeleteEmployee, canDeleteEmployee);
		}

		public async Task LoadAsync()
        {
            if(this.Employees.Any())
            {
                return;
            }

            var employees = await this.employeeDataProvider.GetAllAsync();
            if(employees is not null)
            {
                foreach(var employee in employees)
                {
					Employees.Add(new EmployeeItemViewModel(employee));
                }
            }
        }
        private void AddEmployee(object? parameter)
        {
            var newEmployee = new Employee(1004, "New", "New", false);
            var newViewModel = new EmployeeItemViewModel(newEmployee);
            this.Employees.Add(newViewModel);
            this.SelectedEmployee = newViewModel;
        }

		private bool canDeleteEmployee(object? parameter)
		{
			return this.SelectedEmployee is not null;
		}
		private void DeleteEmployee(object? parameter)
        {
            if(this.SelectedEmployee != null)
            {
                this.Employees.Remove(this.SelectedEmployee);
                this.SelectedEmployee = null;
            }
        }
	}
}
