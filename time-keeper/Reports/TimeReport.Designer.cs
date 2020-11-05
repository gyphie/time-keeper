namespace TimeKeeper
{
	partial class TimeReport
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeReport));
			this.TimeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ProjectSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeDetailGrid = new System.Windows.Forms.DataGridView();
			this.projectSummaryGrid = new System.Windows.Forms.DataGridView();
			this.projectNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.beginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enteredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.TimeDetailBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeDetailGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projectSummaryGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// TimeDetailBindingSource
			// 
			this.TimeDetailBindingSource.DataSource = typeof(Common.TimeDetail);
			// 
			// ProjectSummaryBindingSource
			// 
			this.ProjectSummaryBindingSource.DataSource = typeof(Common.ProjectSummary);
			// 
			// timeDetailGrid
			// 
			this.timeDetailGrid.AllowUserToAddRows = false;
			this.timeDetailGrid.AllowUserToDeleteRows = false;
			this.timeDetailGrid.AllowUserToResizeRows = false;
			this.timeDetailGrid.AutoGenerateColumns = false;
			this.timeDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.timeDetailGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.timeDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.timeDetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectNameDataGridViewTextBoxColumn,
            this.enteredDateDataGridViewTextBoxColumn,
            this.minutesDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn});
			this.timeDetailGrid.DataSource = this.TimeDetailBindingSource;
			this.timeDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeDetailGrid.EnableHeadersVisualStyles = false;
			this.timeDetailGrid.Location = new System.Drawing.Point(0, 0);
			this.timeDetailGrid.Name = "timeDetailGrid";
			this.timeDetailGrid.ReadOnly = true;
			this.timeDetailGrid.RowHeadersVisible = false;
			this.timeDetailGrid.ShowCellErrors = false;
			this.timeDetailGrid.ShowCellToolTips = false;
			this.timeDetailGrid.ShowEditingIcon = false;
			this.timeDetailGrid.ShowRowErrors = false;
			this.timeDetailGrid.Size = new System.Drawing.Size(710, 385);
			this.timeDetailGrid.TabIndex = 2;
			this.timeDetailGrid.Visible = false;
			// 
			// projectSummaryGrid
			// 
			this.projectSummaryGrid.AllowUserToAddRows = false;
			this.projectSummaryGrid.AllowUserToDeleteRows = false;
			this.projectSummaryGrid.AllowUserToResizeRows = false;
			this.projectSummaryGrid.AutoGenerateColumns = false;
			this.projectSummaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.projectSummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.projectSummaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectNameDataGridViewTextBoxColumn1,
            this.beginDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.totalMinutesDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn1});
			this.projectSummaryGrid.DataSource = this.ProjectSummaryBindingSource;
			this.projectSummaryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectSummaryGrid.EnableHeadersVisualStyles = false;
			this.projectSummaryGrid.Location = new System.Drawing.Point(0, 0);
			this.projectSummaryGrid.Name = "projectSummaryGrid";
			this.projectSummaryGrid.ReadOnly = true;
			this.projectSummaryGrid.RowHeadersVisible = false;
			this.projectSummaryGrid.ShowCellErrors = false;
			this.projectSummaryGrid.ShowCellToolTips = false;
			this.projectSummaryGrid.ShowEditingIcon = false;
			this.projectSummaryGrid.ShowRowErrors = false;
			this.projectSummaryGrid.Size = new System.Drawing.Size(710, 385);
			this.projectSummaryGrid.TabIndex = 3;
			this.projectSummaryGrid.Visible = false;
			// 
			// projectNameDataGridViewTextBoxColumn1
			// 
			this.projectNameDataGridViewTextBoxColumn1.DataPropertyName = "ProjectName";
			this.projectNameDataGridViewTextBoxColumn1.FillWeight = 200F;
			this.projectNameDataGridViewTextBoxColumn1.HeaderText = "ProjectName";
			this.projectNameDataGridViewTextBoxColumn1.Name = "projectNameDataGridViewTextBoxColumn1";
			this.projectNameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// beginDateDataGridViewTextBoxColumn
			// 
			this.beginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate";
			this.beginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate";
			this.beginDateDataGridViewTextBoxColumn.Name = "beginDateDataGridViewTextBoxColumn";
			this.beginDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
			this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
			this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalMinutesDataGridViewTextBoxColumn
			// 
			this.totalMinutesDataGridViewTextBoxColumn.DataPropertyName = "TotalMinutes";
			this.totalMinutesDataGridViewTextBoxColumn.FillWeight = 50F;
			this.totalMinutesDataGridViewTextBoxColumn.HeaderText = "TotalMinutes";
			this.totalMinutesDataGridViewTextBoxColumn.Name = "totalMinutesDataGridViewTextBoxColumn";
			this.totalMinutesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// projectIDDataGridViewTextBoxColumn1
			// 
			this.projectIDDataGridViewTextBoxColumn1.DataPropertyName = "ProjectID";
			this.projectIDDataGridViewTextBoxColumn1.HeaderText = "ProjectID";
			this.projectIDDataGridViewTextBoxColumn1.Name = "projectIDDataGridViewTextBoxColumn1";
			this.projectIDDataGridViewTextBoxColumn1.ReadOnly = true;
			this.projectIDDataGridViewTextBoxColumn1.Visible = false;
			// 
			// projectNameDataGridViewTextBoxColumn
			// 
			this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
			this.projectNameDataGridViewTextBoxColumn.FillWeight = 150F;
			this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
			this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
			this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enteredDateDataGridViewTextBoxColumn
			// 
			this.enteredDateDataGridViewTextBoxColumn.DataPropertyName = "EnteredDate";
			this.enteredDateDataGridViewTextBoxColumn.HeaderText = "EnteredDate";
			this.enteredDateDataGridViewTextBoxColumn.Name = "enteredDateDataGridViewTextBoxColumn";
			this.enteredDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// minutesDataGridViewTextBoxColumn
			// 
			this.minutesDataGridViewTextBoxColumn.DataPropertyName = "Minutes";
			this.minutesDataGridViewTextBoxColumn.FillWeight = 50F;
			this.minutesDataGridViewTextBoxColumn.HeaderText = "Minutes";
			this.minutesDataGridViewTextBoxColumn.Name = "minutesDataGridViewTextBoxColumn";
			this.minutesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commentsDataGridViewTextBoxColumn
			// 
			this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
			this.commentsDataGridViewTextBoxColumn.FillWeight = 200F;
			this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
			this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
			this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// projectIDDataGridViewTextBoxColumn
			// 
			this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
			this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
			this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
			this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.projectIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// TimeReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 385);
			this.Controls.Add(this.timeDetailGrid);
			this.Controls.Add(this.projectSummaryGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "TimeReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Week To Date Detail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeReport_FormClosing);
			this.Load += new System.EventHandler(this.TimeReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.TimeDetailBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeDetailGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projectSummaryGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource TimeDetailBindingSource;
		private System.Windows.Forms.BindingSource ProjectSummaryBindingSource;
		private System.Windows.Forms.DataGridView timeDetailGrid;
		private System.Windows.Forms.DataGridView projectSummaryGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enteredDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn minutesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn beginDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalMinutesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn1;
	}
}