using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Common;
using Microsoft.Win32;
using TimeKeeper.Grid;
using TimeKeeper.Properties;

namespace TimeKeeper
{
	public partial class frmTimeKeeper : Form
	{
		public frmTimeKeeper()
		{
			InitializeComponent();

			this.hotKeyHook.KeyPressed += hotKeyHook_KeyPressed;

			try
			{
				this.hotKeyHook.RegisterHotKey(KH.ModifierKeys.Win, Keys.Q);
			}
			catch
			{
				this.hotKeyHook.KeyPressed -= hotKeyHook_KeyPressed;
				this.hotKeyHook = null;
			}

			SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
		}

		void hotKeyHook_KeyPressed(object sender, KH.KeyPressedEventArgs e)
		{
			this.ToggleForm(true, true);
		}

		private DateTime timeSinceLastSave = DateTime.Now;
		private DateTime timeSinceLastPrompt = DateTime.Now;
		private DateTime delayUntil = DateTime.MinValue;
		//private string currentUser = "";
		private KH.KeyboardHook hotKeyHook = new KH.KeyboardHook();
		private TimeReport timeReportForm = new TimeReport();
		private NewProject newProjectForm = new NewProject();
		private Size originalFormSize;

		#region Event Handlers
		/// <summary>
		/// Prevent the form from closing when clicking the X or selecting Close
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmTimeKeeper_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (shouldExit) return;
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.ToggleForm(false);
			}
			else
			{
				try
				{
					Settings setting = Settings.Default;
					setting.Save();
				}
				catch { }
			}
		}

		private void niTimeKeeper_DoubleClick(object sender, EventArgs e)
		{
			this.ToggleForm(true, true);
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ToggleForm(true, true);
		}

		/// <summary>
		/// Position the form, set the interval and show the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmTimeKeeper_Load(object sender, EventArgs e)
		{
			Settings setting = Settings.Default;

			try
			{
				this.trans0StripMenuItem.Tag = TimeKeeper.WindowTransparency.Zero;
				this.trans25StripMenuItem.Tag = TimeKeeper.WindowTransparency.TwentyFive;
				this.trans50StripMenuItem.Tag = TimeKeeper.WindowTransparency.Fifty;
				this.trans75StripMenuItem.Tag = TimeKeeper.WindowTransparency.SeventyFive;

				this.prompt5ToolStripMenuItem.Tag = TimeKeeper.PromptIntervals.Five;
				this.prompt10ToolStripMenuItem.Tag = TimeKeeper.PromptIntervals.Ten;
				this.prompt15ToolStripMenuItem.Tag = TimeKeeper.PromptIntervals.Fifteen;
				this.prompt30ToolStripMenuItem.Tag = TimeKeeper.PromptIntervals.Thirty;
				this.prompt60ToolStripMenuItem.Tag = TimeKeeper.PromptIntervals.OneHour;

				this.minutes15ToolStripMenuItem.Tag = TimeKeeper.DelayTime.Fifteen;
				this.minutes30ToolStripMenuItem.Tag = TimeKeeper.DelayTime.Thirty;
				this.hour1ToolStripMenuItem.Tag = TimeKeeper.DelayTime.OneHour;
				this.hour2ToolStripMenuItem.Tag = TimeKeeper.DelayTime.TwoHour;
				this.hour8ToolStripMenuItem.Tag = TimeKeeper.DelayTime.EightHour;


				TimeKeeper.PromptIntervals interval = (PromptIntervals)setting.interval;
				this.prompt5ToolStripMenuItem.Checked = interval == TimeKeeper.PromptIntervals.Five;
				this.prompt10ToolStripMenuItem.Checked = interval == TimeKeeper.PromptIntervals.Ten;
				this.prompt15ToolStripMenuItem.Checked = interval == TimeKeeper.PromptIntervals.Fifteen;
				this.prompt30ToolStripMenuItem.Checked = interval == TimeKeeper.PromptIntervals.Thirty;
				this.prompt60ToolStripMenuItem.Checked = interval == TimeKeeper.PromptIntervals.OneHour;

				TimeKeeper.WindowTransparency opacity = (WindowTransparency)setting.opacity;
				this.trans0StripMenuItem.Checked = opacity == TimeKeeper.WindowTransparency.Zero;
				this.trans25StripMenuItem.Checked = opacity == TimeKeeper.WindowTransparency.TwentyFive;
				this.trans50StripMenuItem.Checked = opacity == TimeKeeper.WindowTransparency.Fifty;
				this.trans75StripMenuItem.Checked = opacity == TimeKeeper.WindowTransparency.SeventyFive;

				this.StartPosition = FormStartPosition.Manual;
				this.Location = Screen.PrimaryScreen.WorkingArea.Location;
				this.originalFormSize = this.Size;

				this.originalBackColor = this.btnSave.BackColor;
				this.timFlasher.Start();

				string localDataStorePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeKeeper", setting.LocalStoreName);
				TimeKeeperData.ConnectionString = "Data Source=" + localDataStorePath;

				if (!System.IO.File.Exists(localDataStorePath))
				{
					System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(localDataStorePath));
					System.IO.File.Copy(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), setting.LocalStoreName), localDataStorePath);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("There was an error during start up. Report this please. Here are the details\n\n" + ex.Message, "TimeKeeper - Startup Error");
			}

			this.ToggleForm(false);
			this.MoveToScreen(true);

		}

		private string GetWindowsFullName()
		{
			try
			{
				return System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
			}
			catch { }

			return string.Empty;
		}

		private bool shouldExit = false;
		/// <summary>
		/// Exit in a way that bypasses our FormClosing event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			shouldExit = true;
			try
			{
				this.frmTimeKeeper_FormClosing(null, new FormClosingEventArgs(CloseReason.ApplicationExitCall, false));
			}
			finally
			{
				Application.Exit();
			}
		}

		private void timInterval_Tick(object sender, EventArgs e)
		{
			this.CheckMaximumTime();

			if ((DateTime.Now - this.timeSinceLastPrompt).TotalMinutes > (double)Settings.Default.interval && DateTime.Now > this.delayUntil)
			{
				this.SetPauseMenuCheck();
				this.ToggleForm(true);
			}
		}

		private void CheckMaximumTime(bool isWorkstationUnlock = false)
		{
			if (this.timeSinceLastSave.AddHours(4) < DateTime.Now)
			{
				// After four hours we hide the window (they aren't entering time)
				this.ToggleForm(false);

				this.timeSinceLastPrompt = DateTime.Now;	// We reset the prompt time so we don't try to show the form again

				// If they unlock the workstation then we reset the time to 0 and the prompt time so it will prompt again with zero time
				if (isWorkstationUnlock)
				{
					this.timeSinceLastSave = DateTime.Now;
					this.timeSinceLastPrompt = DateTime.Now;
				}
			}
		}

		/// <summary>
		/// Save button hides the form and saves the data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.ToggleForm(false);
			this.SaveTime();
			//this.ClearGrid(false, true, true);
		}

		private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
		{
			bool isUnlock = false;

			switch (e.Reason)
			{
				case SessionSwitchReason.RemoteConnect:
				case SessionSwitchReason.SessionLogon:
				case SessionSwitchReason.SessionRemoteControl:
					isUnlock = System.Windows.Forms.SystemInformation.TerminalServerSession;
					break;
				case SessionSwitchReason.SessionUnlock:
					isUnlock = true;
					break;
				default:
					break;
			}

			if (isUnlock)
			{
				this.CheckMaximumTime(true);
			}
		}

		#endregion

		#region Methods
		/// <summary>
		/// Prep and show the form (or hide it)
		/// </summary>
		/// <param name="show"></param>
		private void ToggleForm(bool show, bool activate = false)
		{
			if (show)
			{
				this.SetupGrid();
				this.UpdateTimeLabel();
				this.UpdateSyncLabel();

				this.MoveToScreen(false);
				this.ShowInTaskbar = true;
				this.WindowState = FormWindowState.Normal;
				this.Size = this.originalFormSize;

				this.timInterval.Stop();
				this.timOpened.Start();
				this.ShowTop(activate);
				this.ShowForm(activate);
			}
			else
			{
				this.Hide();
				this.ShowInTaskbar = false;

				this.timOpened.Stop();

				this.timeSinceLastPrompt = DateTime.Now;
				this.timInterval.Start();

			}
		}

		/// <summary>
		/// Tell the form not to focus on the window when we call Show()
		/// </summary>
		protected override bool ShowWithoutActivation
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Center the form on the screen.  But handle dual monitors.
		/// </summary>
		public void MoveToScreen(bool center)
		{
			int relativeLeft = 0;
			int relativeTop = 0;
			bool foundRelative = false;

			Screen currentScreen = null;
			foreach (Screen screen in Screen.AllScreens)
			{
				if (screen.Bounds.Contains(this.Location.X, this.Location.Y))
				{
					relativeLeft = this.Location.X - screen.Bounds.Left;
					relativeTop = this.Location.Y - screen.Bounds.Top;
					foundRelative = true;
				}

				if (screen.Bounds.Contains(Cursor.Position))
				{
					currentScreen = screen;
				}
			}

			if (currentScreen == null) return;

			if (!center && foundRelative)
			{
				this.Location = new Point(currentScreen.Bounds.Left + relativeLeft, currentScreen.Bounds.Top + relativeTop);

				// If this location would place the window off screen then fall back to centering
				if (!currentScreen.Bounds.Contains(this.Location.X + this.Width, this.Location.Y + this.Height))
				{
					center = true;
				}
			}

			if (center || !foundRelative)
			{
				this.Location = new Point(currentScreen.Bounds.Left + (currentScreen.Bounds.Width / 2) - (this.Width / 2), currentScreen.Bounds.Top + (currentScreen.Bounds.Height / 2) - (this.Height / 2));
			}
		}
		#endregion

		/// <summary>
		/// Focus on the Project Combo box when the window is switched to.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmTimeKeeper_Activated(object sender, EventArgs e)
		{
			this.Opacity = 1.0;
		}

		private void frmTimeKeeper_Deactivate(object sender, EventArgs e)
		{
			this.Opacity = (double)((100 - Settings.Default.opacity) / 100m);
		}



		#region Show the Window
		/* This bit allows us to show the window, keep it top most and does not
		 * steal the window focus.  Using the form.TopMost property always
		 * causes the window to steal focus, so this is used instead.
		 * */

		[DllImport("user32.dll")]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
		static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		static readonly IntPtr HWND_NOTTOPTOP = new IntPtr(-2);
		const UInt32 SWP_NOACTIVATE = 0x0010;
		const UInt32 SWP_SHOWWINDOW = 0x0040;

		protected void ShowTop(bool activate)
		{
			SetWindowPos(this.Handle, HWND_TOPMOST, this.Location.X, this.Location.Y, this.Width, this.Height, activate ? SWP_SHOWWINDOW : SWP_NOACTIVATE);
		}
		protected void ShowNotTop()
		{
			SetWindowPos(this.Handle, HWND_NOTTOPTOP, this.Location.X, this.Location.Y, this.Width, this.Height, SWP_NOACTIVATE);
		}

		#endregion
		protected void ShowForm(bool activate) {
			if (activate) this.Activate();

			try
			{
				this.rows[0].ProjectBox.Focus();
			}
			catch { }

			this.Show();
		}


		private ColorAnimationLoop buttonColorAnimation = null;
		private Color originalBackColor = Color.Empty;
		private void timFlasher_Tick(object sender, EventArgs e)
		{
			if (this.buttonColorAnimation == null)
			{
				this.buttonColorAnimation = new ColorAnimationLoop(this.btnSave.BackColor, Settings.Default.buttonColor, 30, ColorAnimationLoop.LoopType.ForwardBack);
			}

			this.btnSave.BackColor = this.buttonColorAnimation.GetNextColor();
		}

		public void timOpened_Tick(object sender, EventArgs e)
		{
			this.CheckMaximumTime();
			this.UpdateTimeLabel();
		}

		private int MinutesSinceLastSave
		{
			get
			{
				return (int)(DateTime.Now - this.timeSinceLastSave).TotalMinutes;
			}
		}

		private void UpdateTimeLabel()
		{
			int mins = this.MinutesSinceLastSave;

			// Total up the time from the grid
			int minutesRecorded = 0;
			foreach (Row row in this.rows)
			{
				if (row.ProjectBox.SelectedItem != null)
				{
					minutesRecorded += row.GetTime();
				}
			}

			string part1 = Row.ReformatLongTime(minutesRecorded) + " of ";
			string part2 = Row.ReformatLongTime(mins);
			string part3 = (mins - minutesRecorded != 0) ? " (" + (mins - minutesRecorded) + ")" : "";
			this.dispMinutes.Text = part1 + part2 + part3;

			// Check if there is only a single project entry, if so set it's time
			if (!this.rows.Any(r => r.TimeIsDirty) && this.rows.Count(r => r.ProjectBox.SelectedItem != null) == 1)
			{
				this.rows.Single(r => r.ProjectBox.SelectedItem != null).SetTime(this.MinutesSinceLastSave, false);
			}
		}

		private void UpdateSyncLabel()
		{
			int unsyncCount = TimeKeeperData.GetPendingLogCount();
			this.dispUnsyncdLogs.Text = string.Format("Unsync'd Logs: {0}", unsyncCount);
			this.dispUnsyncdLogs.Visible = unsyncCount > 0;
		}

		#region Grid Handling
		private List<Row> rows = new List<Row>();

		public void SetupGrid()
		{
			if (this.rows.Count == 0)
			{
				this.rows.Add(new Row(this.projectBox1, this.timeBox1, this.descriptionBox1));
				this.rows.Add(new Row(this.projectBox2, this.timeBox2, this.descriptionBox2));
				this.rows.Add(new Row(this.projectBox3, this.timeBox3, this.descriptionBox3));
				this.rows.Add(new Row(this.projectBox4, this.timeBox4, this.descriptionBox4));
				this.rows.Add(new Row(this.projectBox5, this.timeBox5, this.descriptionBox5));
				this.rows.Add(new Row(this.projectBox6, this.timeBox6, this.descriptionBox6));
				this.rows.Add(new Row(this.projectBox7, this.timeBox7, this.descriptionBox7));

				foreach (var row in this.rows)
				{
					row.ProjectBox.SelectedIndexChanged += new EventHandler(ProjectBox_SelectedIndexChanged);
					row.ProjectBox.KeyUp += new KeyEventHandler(Row_KeyUp);
					row.TimeBox.TextChanged += new EventHandler(TimeBox_TextChanged);
					row.TimeBox.Leave += new EventHandler(TimeBox_Leave);
				}
			}

			this.RefreshGrid();
		}

		private void RefreshGrid()
		{
			SU.SuspendUpdate.Suspend(this);	// Prevent form from repainting while we update the projects

			try
			{
				List<Project> projects = TimeKeeperData.GetProjects();
				projects.Sort();

				foreach (Row row in this.rows)
				{
					row.Refresh(projects);
				}
			}
			finally
			{
				SU.SuspendUpdate.Resume(this);	// Ok...we can paint again
			}

			// Check if there is only a single project entry, if so set it's time
			if (!this.rows.Any(r => r.TimeIsDirty) && this.rows.Count(r => r.ProjectBox.SelectedItem != null) == 1)
			{
				this.rows.Single(r => r.ProjectBox.SelectedItem != null).SetTime(this.MinutesSinceLastSave, false);
			}
		}

		void TimeBox_TextChanged(object sender, EventArgs e)
		{
			var control = sender as Control;
			bool ignoreEvent = Convert.ToBoolean(control.Tag);
			control.Tag = null;

			if (!ignoreEvent)
			{
				this.UpdateTimeLabel();
			}
		}

		void TimeBox_Leave(object sender, EventArgs e)
		{
			TextBox me = sender as TextBox;
			me.Text = Row.ReformatTime(Row.GetTime(me.Text));
		}

		void Row_KeyUp(object sender, KeyEventArgs e)
		{
			e.Handled = true;
			this.UpdateTimeLabel();
		}

		void ProjectBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var control = sender as Control;
			bool ignoreEvent = Convert.ToBoolean(control.Tag);
			control.Tag = null;

			if (!ignoreEvent)
			{
				this.UpdateTimeLabel();
			}
		}

		public void ClearGrid(bool clearProjects = true, bool clearTime = true, bool clearDescription = true)
		{
			foreach (Row row in this.rows)
			{
				if (clearProjects)
				{
					row.ProjectBox.SelectedIndex = -1;
					row.ProjectBox.Text = "";
				}
				if (clearTime)
				{
					row.SetTime(0, false);
				}
				if (clearDescription)
				{
					row.DescriptionBox.Text = "";
				}
			}
		}

		// Handle grid resizing, always include enough rows to fill the screen
		// Also keep one extra empty row at the end
		// Also, add new rows if they scroll past the last row, but only enough to fill one
		// empty grid
		#endregion


		public void SaveTime()
		{
			List<string> errorMessages = new List<string>();
			bool hasEnteredTimes = false;

			foreach (Row row in this.rows)
			{
				Project project = row.ProjectBox.SelectedItem as Project;
				int minutes = row.GetTime();
				if (project != null && minutes > 0)
				{
					try
					{
						TimeKeeperData.Save(project.ProjectID, minutes, row.DescriptionBox.Text, DateTime.Now);
						row.SetTime(0, false);
						hasEnteredTimes = true;
					}
					catch
					{
						errorMessages.Add(project + "\t" + minutes + "\t" + row.DescriptionBox.Text + "\tSystem Error");
						continue;
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(row.ProjectBox.Text) && row.ProjectBox.SelectedItem == null)
					{
						errorMessages.Add(row.ProjectBox.Text + "\t" + minutes.ToString() + "\t" + row.DescriptionBox.Text + "\tProject not found");
					}
				}
			}

			if (errorMessages.Count > 0)
			{
				MessageBox.Show("Your time was processed but some of your entries could not be save:\n\n" +  string.Join("\n", errorMessages), "TimeKeeper - Error saving time", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (hasEnteredTimes)
			{
				this.timeSinceLastSave = DateTime.Now;
			}

		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			if (this.cdButtonColor.ShowDialog() == DialogResult.OK)
			{
				this.buttonColorAnimation = null;
				this.btnSave.BackColor = this.originalBackColor;
				Settings.Default.buttonColor = this.cdButtonColor.Color;
			}
		}

		private void btnDiscard_Click(object sender, EventArgs e)
		{
			this.timeSinceLastSave = DateTime.Now;

			// Clear entered times
			foreach (var row in this.rows)
			{
				row.SetTime(0, false);
			}

			this.UpdateTimeLabel();

			if (sender == llDiscardTime)
			{
				this.ToggleForm(false);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowNotTop();
			(new AboutBox()).ShowDialog(this);
			this.ShowTop(false);
		}

		private void promptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem clicked = sender as ToolStripMenuItem;
			Settings.Default.interval = (int)clicked.Tag;

			this.prompt5ToolStripMenuItem.Checked = (TimeKeeper.PromptIntervals)clicked.Tag == TimeKeeper.PromptIntervals.Five;
			this.prompt10ToolStripMenuItem.Checked = (TimeKeeper.PromptIntervals)clicked.Tag == TimeKeeper.PromptIntervals.Ten;
			this.prompt15ToolStripMenuItem.Checked = (TimeKeeper.PromptIntervals)clicked.Tag == TimeKeeper.PromptIntervals.Fifteen;
			this.prompt30ToolStripMenuItem.Checked = (TimeKeeper.PromptIntervals)clicked.Tag == TimeKeeper.PromptIntervals.Thirty;
			this.prompt60ToolStripMenuItem.Checked = (TimeKeeper.PromptIntervals)clicked.Tag == TimeKeeper.PromptIntervals.OneHour;

		}
		private void transToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem clicked = sender as ToolStripMenuItem;
			Settings.Default.opacity = (int)clicked.Tag;

			this.trans0StripMenuItem.Checked = (TimeKeeper.WindowTransparency)clicked.Tag == TimeKeeper.WindowTransparency.Zero;
			this.trans25StripMenuItem.Checked = (TimeKeeper.WindowTransparency)clicked.Tag == TimeKeeper.WindowTransparency.TwentyFive;
			this.trans50StripMenuItem.Checked = (TimeKeeper.WindowTransparency)clicked.Tag == TimeKeeper.WindowTransparency.Fifty;
			this.trans75StripMenuItem.Checked = (TimeKeeper.WindowTransparency)clicked.Tag == TimeKeeper.WindowTransparency.SeventyFive;

		}

		private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (sender == this.clearPauseToolStripMenuItem)
			{
				this.delayUntil = DateTime.MinValue;
			}
			else
			{
				this.delayUntil = DateTime.Now.AddMinutes((int)((ToolStripMenuItem)sender).Tag);
				this.ToggleForm(false);
			}

			this.SetPauseMenuCheck(sender as ToolStripMenuItem);
		}

		private void SetPauseMenuCheck(ToolStripMenuItem checkedMenu = null)
		{

			this.minutes15ToolStripMenuItem.Checked = false;
			this.minutes30ToolStripMenuItem.Checked = false;
			this.hour1ToolStripMenuItem.Checked = false;
			this.hour2ToolStripMenuItem.Checked = false;
			this.hour8ToolStripMenuItem.Checked = false;
			this.clearPauseToolStripMenuItem.Checked = false;

			if (checkedMenu != null && checkedMenu != this.clearPauseToolStripMenuItem)
			{
				checkedMenu.Checked = true;
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				this.ToggleForm(false);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ClearGrid(true, true, true);

		}

		private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Program.CheckForUpdate(true))
			{
				Application.Exit();
			}
		}

		private void weekToDateDetailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowNotTop();
			this.timeReportForm.ShowTimeDetail(Settings.Default.userName, this);
			this.ShowTop(false);
		}

		private void weekToDateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowNotTop();
			this.timeReportForm.ShowTimeSummary(Settings.Default.userName, this);
			this.ShowTop(false);
		}

		private void nameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowNotTop();
			string userName = string.IsNullOrWhiteSpace(Settings.Default.userName) ? this.GetWindowsFullName() : Settings.Default.userName;
			do
			{
				userName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name you wish to use for recording time.", "User Name", userName).SafeTrim();
			} while (string.IsNullOrWhiteSpace(userName));

			Settings.Default.userName = userName;
			Settings.Default.Save();

			this.dispName.Text = userName;

			this.ShowTop(false);

		}

		private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowNotTop();

			// Show prompt dialog
			if (this.newProjectForm.LoadAndShowDialog(this)== DialogResult.OK)
			{
				this.RefreshGrid();
			}

			this.ShowTop(false);
		}

		private void dispUnsyncdLogs_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Some time entries could not be sent to the remote database.  They have been saved to your computer and will be sent as soon as the remote database is available again.", "Unsync'd Logs");
		}
	}
}
