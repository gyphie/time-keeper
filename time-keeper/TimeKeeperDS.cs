using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using Common;

namespace TimeKeeper
{
	public class TimeKeeperData
	{
		public static string ConnectionString = string.Empty;

		public static void Save(int projectID, int minutes, string description, DateTime timeStamp) {
			SQLiteConnection conn = null;
			SQLiteCommand cmd = null;
			try
			{
				conn = new SQLiteConnection(TimeKeeperData.ConnectionString);
				conn.Open();

				cmd = new SQLiteCommand("INSERT INTO Log(ProjectID, Minutes, Description, EntryDate) VALUES(@ProjectID, @MinutesAllocated, @Description, @EntryDatetime)", conn);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("@ProjectID", projectID);
				cmd.Parameters.AddWithValue("@MinutesAllocated", minutes);
				cmd.Parameters.AddWithValue("@EntryDatetime", timeStamp.Ticks);
				cmd.Parameters.AddWithValue("@Description", description);

				cmd.ExecuteNonQuery();

			}
			finally
			{
				if (cmd != null)
				{
					cmd.Dispose();
				}

				if (conn != null)
				{
					conn.Close();
					conn.Dispose();
				}
			}
		}

		private class LogContainer {
			public int ProjectID { get; set; }
			public string UserName { get; set; }
			public int Minutes { get; set; }
			public string Description { get; set; }
			public DateTime EntryDate { get; set; }
		}

		public static List<Project> GetProjects()
		{
			List<Project> projects = new List<Project>();

			SQLiteConnection conn = null;
			SQLiteCommand cmd = null;
			SQLiteDataReader reader = null;
			try
			{

				conn = new SQLiteConnection(TimeKeeperData.ConnectionString);
				conn.Open();

				cmd = new SQLiteCommand("SELECT ProjectID, Name, Department FROM Project", conn);
				cmd.CommandType = CommandType.Text;


				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					projects.Add(new Project() { ProjectID = reader.GetInt32(0), Name = reader.GetString(1), Department = reader.GetString(2) });
				}
			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
					reader.Dispose();
				}

				if (cmd != null)
				{
					cmd.Dispose();
				}

				if (conn != null)
				{
					conn.Close();
					conn.Dispose();
				}
			}

			return projects;
		}

		private static void CacheProjects(List<Project> projects)
		{
			/* We failed to retrieve and cache the projects so load the previously cached projects instead */
			SQLiteConnection conn = null;
			SQLiteCommand cmd = null;
			SQLiteDataReader reader = null;
			try
			{

				conn = new SQLiteConnection(TimeKeeperData.ConnectionString);
				conn.Open();

				cmd = new SQLiteCommand("", conn);
				cmd.CommandType = CommandType.Text;


				cmd.CommandText = "DELETE FROM Project";
				cmd.ExecuteNonQuery();

				foreach (Project project in projects)
				{
					cmd.Parameters.Clear();
					cmd.CommandText ="INSERT INTO Project(ProjectID, Name, Department) VALUES(@ProjectID, @Name, @Department)";

					SQLiteParameter param = cmd.CreateParameter();
					param.ParameterName = "ProjectID";
					param.Value = project.ProjectID;
					cmd.Parameters.Add(param);

					param = cmd.CreateParameter();
					param.ParameterName = "Name";
					param.Value = project.Name;
					cmd.Parameters.Add(param);

					param = cmd.CreateParameter();
					param.ParameterName = "Department";
					param.Value = project.Department;
					cmd.Parameters.Add(param);


					cmd.ExecuteNonQuery();
				}

			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
					reader.Dispose();
				}

				if (cmd != null)
				{
					cmd.Dispose();
				}

				if (conn != null)
				{
					conn.Close();
					conn.Dispose();
				}
			}

		}

		public static int GetPendingLogCount()
		{
			int pendingLogCount = 0;


			SQLiteConnection conn = null;
			SQLiteCommand cmd = null;
			try
			{

				conn = new SQLiteConnection(TimeKeeperData.ConnectionString);
				conn.Open();

				cmd = new SQLiteCommand("SELECT COUNT(*) FROM Log", conn as SQLiteConnection);
				cmd.CommandType = CommandType.Text;


				pendingLogCount = Convert.ToInt32(cmd.ExecuteScalar());
			}
			finally
			{
				if (cmd != null)
				{
					cmd.Dispose();
				}

				if (conn != null)
				{
					conn.Close();
					conn.Dispose();
				}
			}

			return pendingLogCount;
		}

	}
}
