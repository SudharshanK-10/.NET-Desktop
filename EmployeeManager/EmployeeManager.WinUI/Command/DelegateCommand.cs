﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManager.WinUI.Command
{
	public class DelegateCommand : ICommand
	{
		private readonly Action<object?> execute;
		private readonly Func<object?, bool>? canExecute;

		public DelegateCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
			ArgumentNullException.ThrowIfNull(execute);
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty); 

        public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return this.canExecute is null || this.canExecute(parameter);
		}

		public void Execute(object? parameter)
		{
			this.execute(parameter);
		}
	}
}
