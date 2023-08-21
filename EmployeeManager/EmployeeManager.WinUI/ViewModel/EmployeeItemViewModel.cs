using EmployeeManager.WinUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.WinUI.ViewModel
{
    public class EmployeeItemViewModel : ViewModelBase
    {
		private readonly Employee model;

		public EmployeeItemViewModel(Employee model) 
        {
			this.model = model;
		}

		public int Id => this.model.Id;

		public string? FirstName
		{
			get => this.model.FirstName;
			set
			{
				if(this.model.FirstName != value) 
				{
					this.model.FirstName = value;
					RaisePropertyChanged();
				}
			}
		}
		public string? LastName
		{
			get => this.model.LastName;
			set
			{
				if (this.model.LastName != value)
				{
					this.model.LastName = value;
					RaisePropertyChanged();
				}
			}
		}
		public bool IsDeveloper
		{
			get => this.model.IsDeveloper;
			set
			{
				if (this.model.IsDeveloper != value)
				{
					this.model.IsDeveloper = value;
					RaisePropertyChanged();
				}
			}
		}

	}
}
