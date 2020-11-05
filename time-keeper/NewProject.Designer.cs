namespace TimeKeeper
{
	partial class NewProject
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.cmboDepartment = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(527, 65);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(446, 65);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(9, 9);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(71, 13);
			this.lblProjectName.TabIndex = 0;
			this.lblProjectName.Text = "&Project Name";
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Location = new System.Drawing.Point(203, 8);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(62, 13);
			this.lblDepartment.TabIndex = 2;
			this.lblDepartment.Text = "&Department";
			// 
			// lblStartDate
			// 
			this.lblStartDate.AutoSize = true;
			this.lblStartDate.Location = new System.Drawing.Point(363, 8);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(55, 13);
			this.lblStartDate.TabIndex = 4;
			this.lblStartDate.Text = "Start &Date";
			// 
			// lblEndDate
			// 
			this.lblEndDate.AutoSize = true;
			this.lblEndDate.Location = new System.Drawing.Point(484, 8);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(52, 13);
			this.lblEndDate.TabIndex = 6;
			this.lblEndDate.Text = "&End Date";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(12, 25);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(188, 20);
			this.txtProjectName.TabIndex = 1;
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Location = new System.Drawing.Point(366, 25);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(115, 20);
			this.dtpStartDate.TabIndex = 5;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Location = new System.Drawing.Point(487, 25);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(115, 20);
			this.dtpEndDate.TabIndex = 7;
			// 
			// cmboDepartment
			// 
			this.cmboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmboDepartment.FormattingEnabled = true;
			this.cmboDepartment.Location = new System.Drawing.Point(206, 25);
			this.cmboDepartment.Name = "cmboDepartment";
			this.cmboDepartment.Size = new System.Drawing.Size(154, 21);
			this.cmboDepartment.TabIndex = 3;
			// 
			// NewProject
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(615, 95);
			this.Controls.Add(this.cmboDepartment);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.txtProjectName);
			this.Controls.Add(this.lblEndDate);
			this.Controls.Add(this.lblStartDate);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.lblProjectName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(631, 133);
			this.Name = "NewProject";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add a Project";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblStartDate;
		private System.Windows.Forms.Label lblEndDate;
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.ComboBox cmboDepartment;
	}
}