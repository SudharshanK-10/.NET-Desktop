namespace EmployeeManager.WinForms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			pnlHeader = new Panel();
			lblHeader = new Label();
			pnlNavigation = new Panel();
			lsbEmployees = new ListBox();
			pnlRefresh = new Panel();
			btnRefresh = new Button();
			pnlMainArea = new Panel();
			btnSave = new Button();
			chkIsCoffeeDrinker = new CheckBox();
			cboJobRole = new ComboBox();
			dtpEntryDate = new DateTimePicker();
			txtFirstName = new TextBox();
			lblJobRole = new Label();
			lblEntryDate = new Label();
			lblFirstName = new Label();
			employeeBindingSource = new BindingSource(components);
			pnlHeader.SuspendLayout();
			pnlNavigation.SuspendLayout();
			pnlRefresh.SuspendLayout();
			pnlMainArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
			SuspendLayout();
			// 
			// pnlHeader
			// 
			pnlHeader.BackColor = SystemColors.ControlDark;
			pnlHeader.Controls.Add(lblHeader);
			pnlHeader.Dock = DockStyle.Top;
			pnlHeader.Location = new Point(0, 0);
			pnlHeader.Name = "pnlHeader";
			pnlHeader.Size = new Size(960, 125);
			pnlHeader.TabIndex = 0;
			// 
			// lblHeader
			// 
			lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			lblHeader.AutoSize = true;
			lblHeader.Location = new Point(368, 51);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(263, 30);
			lblHeader.TabIndex = 0;
			lblHeader.Text = "Employee Manager Portal";
			lblHeader.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlNavigation
			// 
			pnlNavigation.Controls.Add(lsbEmployees);
			pnlNavigation.Controls.Add(pnlRefresh);
			pnlNavigation.Dock = DockStyle.Left;
			pnlNavigation.Location = new Point(0, 125);
			pnlNavigation.Name = "pnlNavigation";
			pnlNavigation.Size = new Size(258, 449);
			pnlNavigation.TabIndex = 1;
			// 
			// lsbEmployees
			// 
			lsbEmployees.Dock = DockStyle.Fill;
			lsbEmployees.FormattingEnabled = true;
			lsbEmployees.ItemHeight = 30;
			lsbEmployees.Location = new Point(0, 53);
			lsbEmployees.Name = "lsbEmployees";
			lsbEmployees.Size = new Size(258, 396);
			lsbEmployees.TabIndex = 1;
			// 
			// pnlRefresh
			// 
			pnlRefresh.Controls.Add(btnRefresh);
			pnlRefresh.Dock = DockStyle.Top;
			pnlRefresh.Location = new Point(0, 0);
			pnlRefresh.Name = "pnlRefresh";
			pnlRefresh.Size = new Size(258, 53);
			pnlRefresh.TabIndex = 0;
			// 
			// btnRefresh
			// 
			btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnRefresh.Location = new Point(29, 6);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(189, 37);
			btnRefresh.TabIndex = 0;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// pnlMainArea
			// 
			pnlMainArea.Controls.Add(btnSave);
			pnlMainArea.Controls.Add(chkIsCoffeeDrinker);
			pnlMainArea.Controls.Add(cboJobRole);
			pnlMainArea.Controls.Add(dtpEntryDate);
			pnlMainArea.Controls.Add(txtFirstName);
			pnlMainArea.Controls.Add(lblJobRole);
			pnlMainArea.Controls.Add(lblEntryDate);
			pnlMainArea.Controls.Add(lblFirstName);
			pnlMainArea.Dock = DockStyle.Fill;
			pnlMainArea.Location = new Point(258, 125);
			pnlMainArea.Name = "pnlMainArea";
			pnlMainArea.Size = new Size(702, 449);
			pnlMainArea.TabIndex = 2;
			// 
			// btnSave
			// 
			btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnSave.Location = new Point(279, 383);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(157, 37);
			btnSave.TabIndex = 7;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// chkIsCoffeeDrinker
			// 
			chkIsCoffeeDrinker.AutoSize = true;
			chkIsCoffeeDrinker.Location = new Point(61, 323);
			chkIsCoffeeDrinker.Name = "chkIsCoffeeDrinker";
			chkIsCoffeeDrinker.Size = new Size(197, 34);
			chkIsCoffeeDrinker.TabIndex = 6;
			chkIsCoffeeDrinker.Text = "is Coffee Drinker";
			chkIsCoffeeDrinker.UseVisualStyleBackColor = true;
			// 
			// cboJobRole
			// 
			cboJobRole.DropDownStyle = ComboBoxStyle.DropDownList;
			cboJobRole.FormattingEnabled = true;
			cboJobRole.Location = new Point(61, 258);
			cboJobRole.Name = "cboJobRole";
			cboJobRole.Size = new Size(312, 38);
			cboJobRole.TabIndex = 5;
			// 
			// dtpEntryDate
			// 
			dtpEntryDate.Location = new Point(61, 158);
			dtpEntryDate.Name = "dtpEntryDate";
			dtpEntryDate.Size = new Size(265, 36);
			dtpEntryDate.TabIndex = 4;
			// 
			// txtFirstName
			// 
			txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtFirstName.Location = new Point(61, 62);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(613, 36);
			txtFirstName.TabIndex = 3;
			// 
			// lblJobRole
			// 
			lblJobRole.AutoSize = true;
			lblJobRole.Location = new Point(61, 225);
			lblJobRole.Name = "lblJobRole";
			lblJobRole.Size = new Size(95, 30);
			lblJobRole.TabIndex = 2;
			lblJobRole.Text = "Job Role";
			// 
			// lblEntryDate
			// 
			lblEntryDate.AutoSize = true;
			lblEntryDate.Location = new Point(61, 113);
			lblEntryDate.Name = "lblEntryDate";
			lblEntryDate.Size = new Size(113, 30);
			lblEntryDate.TabIndex = 1;
			lblEntryDate.Text = "Entry Date";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Location = new Point(61, 29);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(117, 30);
			lblFirstName.TabIndex = 0;
			lblFirstName.Text = "First Name";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(960, 574);
			Controls.Add(pnlMainArea);
			Controls.Add(pnlNavigation);
			Controls.Add(pnlHeader);
			Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "MainForm";
			Text = "Employee Manager Portal";
			Load += MainForm_Load;
			pnlHeader.ResumeLayout(false);
			pnlHeader.PerformLayout();
			pnlNavigation.ResumeLayout(false);
			pnlRefresh.ResumeLayout(false);
			pnlMainArea.ResumeLayout(false);
			pnlMainArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlHeader;
		private Panel pnlNavigation;
		private Panel pnlMainArea;
		private Panel pnlRefresh;
		private Button btnRefresh;
		private ListBox lsbEmployees;
		private ComboBox cboJobRole;
		private DateTimePicker dtpEntryDate;
		private TextBox txtFirstName;
		private Label lblJobRole;
		private Label lblEntryDate;
		private Label lblFirstName;
		private Button btnSave;
		private CheckBox chkIsCoffeeDrinker;
		private Label lblHeader;
		private BindingSource employeeBindingSource;
	}
}