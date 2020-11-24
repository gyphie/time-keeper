namespace TimeKeeper
{
	partial class AddEditProject
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
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.cmboDepartment = new System.Windows.Forms.ComboBox();
			this.cbIsActive = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(196, 131);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(115, 131);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
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
			this.lblDepartment.Location = new System.Drawing.Point(9, 48);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(62, 13);
			this.lblDepartment.TabIndex = 2;
			this.lblDepartment.Text = "&Department";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProjectName.Location = new System.Drawing.Point(12, 25);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(262, 20);
			this.txtProjectName.TabIndex = 1;
			// 
			// cmboDepartment
			// 
			this.cmboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmboDepartment.FormattingEnabled = true;
			this.cmboDepartment.Location = new System.Drawing.Point(12, 64);
			this.cmboDepartment.Name = "cmboDepartment";
			this.cmboDepartment.Size = new System.Drawing.Size(262, 21);
			this.cmboDepartment.TabIndex = 3;
			// 
			// cbIsActive
			// 
			this.cbIsActive.AutoSize = true;
			this.cbIsActive.Location = new System.Drawing.Point(12, 91);
			this.cbIsActive.Name = "cbIsActive";
			this.cbIsActive.Size = new System.Drawing.Size(56, 17);
			this.cbIsActive.TabIndex = 4;
			this.cbIsActive.Text = "Active";
			this.cbIsActive.UseVisualStyleBackColor = true;
			// 
			// AddEditProject
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.cbIsActive);
			this.Controls.Add(this.cmboDepartment);
			this.Controls.Add(this.txtProjectName);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.lblProjectName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "AddEditProject";
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
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.ComboBox cmboDepartment;
		private System.Windows.Forms.CheckBox cbIsActive;
	}
}