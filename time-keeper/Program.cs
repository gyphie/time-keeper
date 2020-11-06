using Common.Helpers.DataTypes;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using TimeKeeper.Properties;

namespace TimeKeeper
{
	public static class Program
	{
		internal static Mutex singleInstance;
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				var assemblyVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
				if (Settings.Default.SettingsVersion != assemblyVersion)
				{
					Settings.Default.Upgrade();
					Settings.Default.SettingsVersion = assemblyVersion;
					Settings.Default.Save();
				}
			}
			catch { }

			try
			{
#if DEBUG
				Program.singleInstance = new Mutex(true, "TimeKeeperDebug");
#else
				Program.singleInstance = new Mutex(true, "TimeKeeper");
#endif
				if (Program.singleInstance.WaitOne(0, false))
				{
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

		static void HandleError(Exception ex)
		{
			try
			{
				if (DialogResult.Yes == MessageBox.Show("An error occurred. Here's the details\n\n" + ex.ToDetailText() + "\n\nWould you like to restart?", "TimeKeeper - Exceptional Exception!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false))
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
