using System;
using System.Threading;
using System.Windows.Forms;
using TimeKeeper.Properties;

namespace TimeKeeper
{
	public static class Program
	{
		internal static Mutex singleInstance;
		internal static bool updateWithoutPrompt = false;
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0 && args[0] != null && args[0].ToLower() == "/u")
			{
				updateWithoutPrompt = true;
			}

			try
			{
				if (Settings.Default.UpgradeRequired)
				{
					Settings.Default.Upgrade();
					Settings.Default.UpgradeRequired = false;
					Settings.Default.Save();
				}
			}
			catch { }

			try
			{
#if DEBUG
				//MessageBox.Show("Chance To Debug");
				Program.singleInstance = new Mutex(true, "TimeKeeperDebug");
#else
				Program.singleInstance = new Mutex(true, "TimeKeeper");
#endif
				if (Program.singleInstance.WaitOne(0, false))
				{
					bool hasUpdate = false;

					hasUpdate = CheckForUpdate();
#if !DEBUG
#endif

					if (hasUpdate) return;

					Application.EnableVisualStyles();
					Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new frmTimeKeeper());
				}
				else
				{

				}
			}
			catch (Exception ex)
			{
				HandleError(ex);
			}
		}

		static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			HandleError(e.Exception);
		}

		public static bool CheckForUpdate(bool alertOnNone = false)
		{
			string remotePath = Settings.Default.autoUpdateUrl;
			string currentVersion = Application.ProductVersion;

			if (AutoUpdate.UpdateFiles(remotePath, currentVersion, false))
			{
				if (updateWithoutPrompt || MessageBox.Show("An update is available. Would you like to update now?", "Time Keeper - Automatic Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					// Check for privileges, if not restart elevated
					bool hasAdminPrivileges = false;
					try
					{
						hasAdminPrivileges = !CSUACSelfElevation.UacSelfElevation.Elevate("/u");	// elevates and restarts the application
					}
					catch
					{
						MessageBox.Show("Could not acquire the privileges for automatic update. Continuing with the current version.", "TimeKeeper - Automatic Update", MessageBoxButtons.OK);
						return false;
					}

					if (hasAdminPrivileges)    // If we elevated priv then it will start a new process and we should end this one allowing the other to update
					{
						if (AutoUpdate.UpdateFiles(remotePath, currentVersion, true))
						{
							Program.singleInstance.Close();
							System.Diagnostics.Process.Start(CSUACSelfElevation.UacSelfElevation.GetProcess("", false));
							return true;
						}
						else
						{
							MessageBox.Show("The automatic update did not complete. Starting the current version.", "TimeKeeper - Automatic Update", MessageBoxButtons.OK);
						}
					}
					else
					{
						return true;	// We have an update but we need to return to allow the process to end so the elevated process can do the update.
					}
				}
			}
			else if (alertOnNone)
			{
				MessageBox.Show("No updates found.", "TimeKeeper - Automatic Update", MessageBoxButtons.OK);
			}

			return false;
		}

		static void HandleError(Exception ex)
		{
			try
			{
				if (DialogResult.Yes == MessageBox.Show("An error occurred. Here's the details\n\n" + DAL.Utilities.Library.DataTypes.Strings.ExceptionToDetailText(ex) + "\n\nWould you like to restart?", "TimeKeeper - Exceptional Exception!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false))
				{
					Program.singleInstance.Close();
					System.Diagnostics.Process.Start(CSUACSelfElevation.UacSelfElevation.GetProcess("", false));
				}

				Application.Exit();
			}
			catch {
				throw ex;
			}
		}
	}
}
