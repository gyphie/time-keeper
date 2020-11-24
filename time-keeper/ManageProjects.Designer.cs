namespace TimeKeeper
{
	partial class ManageProjects
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
			this.btnClose = new System.Windows.Forms.Button();
			this.lblProjects = new System.Windows.Forms.Label();
			this.cbShowInactive = new System.Windows.Forms.CheckBox();
			this.btnAddProject = new System.Windows.Forms.Button();
			this.lvProjects = new System.Windows.Forms.ListView();
			this.chProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(447, 265);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblProjects
			// 
			this.lblProjects.AutoSize = true;
			this.lblProjects.Location = new System.Drawing.Point(11, 10);
			this.lblProjects.Name = "lblProjects";
			this.lblProjects.Size = new System.Drawing.Size(45, 13);
			this.lblProjects.TabIndex = 0;
			this.lblProjects.Text = "&Projects";
			// 
			// cbShowInactive
			// 
			this.cbShowInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbShowInactive.AutoSize = true;
			this.cbShowInactive.Location = new System.Drawing.Point(25, 269);
			this.cbShowInactive.Name = "cbShowInactive";
			this.cbShowInactive.Size = new System.Drawing.Size(135, 17);
			this.cbShowInactive.TabIndex = 2;
			this.cbShowInactive.Text = "&Show Inactive Projects";
			this.cbShowInactive.UseVisualStyleBackColor = true;
			this.cbShowInactive.CheckedChanged += new System.EventHandler(this.cbShowInactive_CheckedChanged);
			// 
			// btnAddProject
			// 
			this.btnAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddProject.Location = new System.Drawing.Point(366, 265);
			this.btnAddProject.Name = "btnAddProject";
			this.btnAddProject.Size = new System.Drawing.Size(75, 23);
			this.btnAddProject.TabIndex = 3;
			this.btnAddProject.Text = "&Add";
			this.btnAddProject.UseVisualStyleBackColor = true;
			this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
			// 
			// lvProjects
			// 
			this.lvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProject,
            this.chDepartment,
            this.chActive});
			this.lvProjects.FullRowSelect = true;
			this.lvProjects.GridLines = true;
			this.lvProjects.HideSelection = false;
			this.lvProjects.Location = new System.Drawing.Point(19, 27);
			this.lvProjects.MultiSelect = false;
			this.lvProjects.Name = "lvProjects";
			this.lvProjects.ShowGroups = false;
			this.lvProjects.Size = new System.Drawing.Size(503, 232);
			this.lvProjects.TabIndex = 1;
			this.lvProjects.UseCompatibleStateImageBehavior = false;
			this.lvProjects.View = System.Windows.Forms.View.Details;
			this.lvProjects.DoubleClick += new System.EventHandler(this.lvProjects_DoubleClick);
			// 
			// chProject
			// 
			this.chProject.Text = "Project";
			this.chProject.Width = 210;
			// 
			// chDepartment
			// 
			this.chDepartment.Text = "Department";
			this.chDepartment.Width = 217;
			// 
			// chActive
			// 
			this.chActive.Text = "Active";
			this.chActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chActive.Width = 44;
			// 
			// ManageProjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(535, 295);
			this.Controls.Add(this.lvProjects);
			this.Controls.Add(this.cbShowInactive);
			this.Controls.Add(this.lblProjects);
			this.Controls.Add(this.btnAddProject);
			this.Controls.Add(this.btnClose);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 260);
			this.Name = "ManageProjects";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Manage Projects";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageProjects_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblProjects;
		private System.Windows.Forms.CheckBox cbShowInactive;
		private System.Windows.Forms.Button btnAddProject;
		private System.Windows.Forms.ListView lvProjects;
		private System.Windows.Forms.ColumnHeader chProject;
		private System.Windows.Forms.ColumnHeader chDepartment;
		private System.Windows.Forms.ColumnHeader chActive;
	}
}