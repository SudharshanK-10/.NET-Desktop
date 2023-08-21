using EmployeeManager.WinUI.Data;
using EmployeeManager.WinUI.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Authentication.ExtendedProtection;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmployeeManager.WinUI
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : Application
	{
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		/// 


		private Window? m_window;
		private readonly ServiceProvider _serviceProvider;

		public App()
		{
			this.InitializeComponent();
			ServiceCollection services = new();
			ConfigureServices(services);
			_serviceProvider = services.BuildServiceProvider();
		}

		private void ConfigureServices(ServiceCollection services)
			//Parameters are checked and created automatically in dependency injection
		{
			services.AddTransient<MainWindow>();
			services.AddTransient<MainViewModel>();
			services.AddTransient<IEmployeeDataProvider, EmployeeDataProvider>();
		}

		/// <summary>
		/// Invoked when the application is launched.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
		{
			m_window = _serviceProvider.GetService<MainWindow>();
			m_window?.Activate();
		}

	}
}
