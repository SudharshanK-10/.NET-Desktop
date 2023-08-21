using EmployeeManager.WinUI.Data;
using EmployeeManager.WinUI.ViewModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmployeeManager.WinUI
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		public MainViewModel ViewModel { get; }

		public MainWindow(MainViewModel viewModel)
		{
			this.InitializeComponent();
			Title = "Employee Manager";
			ViewModel = viewModel;
			//root.DataContext = ViewModel;
			root.Loaded += Root_Loaded;
		}

		private async void Root_Loaded(object sender, RoutedEventArgs e)
		{
			await this.ViewModel.LoadAsync();
		}

		private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
		{
			var currColumn = (int)customerListGrid.GetValue(Grid.ColumnProperty);
			int newColumn = currColumn == 0 ? 2 : 0;
			customerListGrid.SetValue(Grid.ColumnProperty, newColumn);
			changePaneBtnIcon.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }

		private void ToggleTheme_Click(object sender, RoutedEventArgs e)
		{
			if(root.RequestedTheme == ElementTheme.Light)
			{
				root.RequestedTheme = ElementTheme.Dark;
				ToggleThemeButton.Content = "Light Theme";
			}
			else
			{
				root.RequestedTheme = ElementTheme.Light;
				ToggleThemeButton.Content = "Dark Theme";
			}
		}
	}
}
