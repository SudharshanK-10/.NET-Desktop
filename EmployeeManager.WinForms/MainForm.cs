using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;

namespace EmployeeManager.WinForms
{
	public partial class MainForm : Form
	{
		private readonly MainViewModel viewModel;

		public MainForm()
		{
			InitializeComponent();
			this.viewModel = new MainViewModel(new EmployeeDataProvider());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			this.viewModel.Load();
			employeeBindingSource.DataSource = this.viewModel.Employees;
			lsbEmployees.DataSource = employeeBindingSource;
			lsbEmployees.DisplayMember = "FirstName";

			cboJobRole.DataSource = this.viewModel.JobRoles;
			cboJobRole.DisplayMember = "RoleName";
			cboJobRole.ValueMember = "Id";

			var areDataBindingsIntialized = cboJobRole.DataBindings.Count > 0;
			if (areDataBindingsIntialized)
			{
				employeeBindingSource.ResetBindings(false);
			}
			else
			{
				cboJobRole.DataBindings.Add("SelectedValue", employeeBindingSource, "JobRoleId");

				txtFirstName.DataBindings.Add("Text", employeeBindingSource, "FirstName",
					false, DataSourceUpdateMode.OnPropertyChanged);

				dtpEntryDate.DataBindings.Add("Value", employeeBindingSource, "EntryDate");
				chkIsCoffeeDrinker.DataBindings.Add("Checked", employeeBindingSource, "IsCoffeeDrinker");
				btnSave.DataBindings.Add("Enabled", employeeBindingSource, "CanSave");
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (employeeBindingSource.Current is EmployeeViewModel employeeViewModel
				&& employeeViewModel.CanSave)
			{
				employeeViewModel.Save();
			}
		}
	}
}