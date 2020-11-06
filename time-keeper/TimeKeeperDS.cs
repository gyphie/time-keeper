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

		public static void SaveLog(long projectID, string userName, long minutes, string description, DateTime timeStamp)
		{
			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				using (var cmd = new SQLiteCommand("INSERT INTO Log(ProjectID, UserName, Minutes, Description, EntryDate) VALUES(@ProjectID, @UserName, @Minutes, @Description, @EntryDatetime)", conn))
				{
					cmd.CommandType = CommandType.Text;

					cmd.Parameters.AddWithValue("@ProjectID", projectID);
					cmd.Parameters.AddWithValue("@UserName", userName);
					cmd.Parameters.AddWithValue("@Minutes", minutes);
					cmd.Parameters.AddWithValue("@EntryDatetime", timeStamp.Ticks);
					cmd.Parameters.AddWithValue("@Description", description);

					cmd.ExecuteNonQuery();
				}
			}
		}

		public static void SaveProject(long projectID, string projectName, string department, DateTime beginDate, DateTime endDate)
		{
			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				if (projectID <= 0)
				{
					using (var cmd = new SQLiteCommand("INSERT INTO Project(Name, Department, BeginDate, EndDate) VALUES(@Name, @Department, @BeginDate, @EndDate)", conn))
					{
						cmd.CommandType = CommandType.Text;

						cmd.Parameters.AddWithValue("@Name", projectName);
						cmd.Parameters.AddWithValue("@Department", department);
						cmd.Parameters.AddWithValue("@BeginDate", beginDate.Ticks);
						cmd.Parameters.AddWithValue("@EndDate", endDate.Ticks);

						cmd.ExecuteNonQuery();
					}
				}
				else
				{
					using (var cmd = new SQLiteCommand("UPDATE Project SET Name = @Name, Department = @Department, BeginDate = @BeginDate, EndDate = @EndDate ) WHERE ProjectID = @ProjectID", conn))
					{
						cmd.CommandType = CommandType.Text;

						cmd.Parameters.AddWithValue("@ProjectID", projectID);
						cmd.Parameters.AddWithValue("@Name", projectName);
						cmd.Parameters.AddWithValue("@Department", department);
						cmd.Parameters.AddWithValue("@BeginDate", beginDate.Ticks);
						cmd.Parameters.AddWithValue("@EndDate", endDate.Ticks);

						cmd.ExecuteNonQuery();
					}

				}
			}
		}

		public static List<ProjectSummary> GetProjectSummary(DateTime beginDate, DateTime endDate)
		{
			var projectSummary = new List<ProjectSummary>();

			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				using (var cmd = new SQLiteCommand("SELECT Project.ProjectID, Project.Name, Project.BeginDate, Project.EndDate, LogSum.TotalMinutes FROM (SELECT ProjectID, SUM(minutes) AS TotalMinutes FROM Log WHERE EntryDate > @BeginDate AND EntryDate <= @EndDate GROUP BY ProjectID) AS LogSum INNER JOIN Project ON LogSum.ProjectID = Project.ProjectID", conn))
				{
					cmd.CommandType = CommandType.Text;

					cmd.Parameters.AddWithValue("@BeginDate", beginDate.Ticks);
					cmd.Parameters.AddWithValue("@EndDate", endDate.Ticks);


					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int idx = 0;
							projectSummary.Add(new ProjectSummary()
							{
								ProjectID = reader.GetInt64(idx++),
								ProjectName = reader.GetString(idx++),
								BeginDate = new DateTime(reader.GetInt64(idx++)),
								EndDate = new DateTime(reader.GetInt64(idx++)),
								TotalMinutes = reader.GetInt64(idx++)
						
							});
						}
					}
				}
			}

			return projectSummary;
		}

		public static List<TimeDetail> GetTimeDetail(DateTime beginDate, DateTime endDate)
		{
			var logs = new List<TimeDetail>();

			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				using (var cmd = new SQLiteCommand("SELECT Project.ProjectID, Project.Name, Log.UserName, Log.Minutes, Log.Description, Log.EntryDate FROM Log INNER JOIN Project ON Log.ProjectID = Project.ProjectID WHERE EntryDate > @BeginDate AND EntryDate <= @EndDate", conn))
				{
					cmd.CommandType = CommandType.Text;

					cmd.Parameters.AddWithValue("@BeginDate", beginDate.Ticks);
					cmd.Parameters.AddWithValue("@EndDate", endDate.Ticks);


					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int idx = 0;
							logs.Add(new TimeDetail() {
								ProjectID = reader.GetInt64(idx++),
								ProjectName = reader.GetString(idx++),
								UserName = reader.GetString(idx++),
								Minutes = reader.GetInt64(idx++),
								Description = reader.GetString(idx++),
								EntryDate = new DateTime(reader.GetInt64(idx++))
							});
						}
					}
				}
			}

			return logs;
		}

		public static List<Project> GetProjects()
		{
			var projects = new List<Project>();

			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				using (var cmd = new SQLiteCommand("SELECT ProjectID, Name, Department, BeginDate, EndDate FROM Project", conn))
				{
					cmd.CommandType = CommandType.Text;

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int idx = 0;
							projects.Add(new Project() {
								ProjectID = reader.GetInt64(idx++),
								Name = reader.GetString(idx++),
								Department = reader.GetString(idx++),
								BeginDate = new DateTime(reader.GetInt64(idx++)),
								EndDate = new DateTime(reader.GetInt64(idx++))
							});
						}
					}
				}
			}
			
			return projects;
		}
	}
}
