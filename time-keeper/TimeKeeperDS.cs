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

				// note - by ommitted LogID SQLite will generate the value
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

		public static void SaveProject(long projectID, string projectName, string department, DateTime createDate, bool isActive)
		{
			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				if (projectID <= 0)
				{
					using (var cmd = new SQLiteCommand("INSERT INTO Project(Name, Department, CreateDate, IsActive) VALUES(@Name, @Department, @CreateDate, @IsActive)", conn))
					{
						cmd.CommandType = CommandType.Text;

						cmd.Parameters.AddWithValue("@Name", projectName);
						cmd.Parameters.AddWithValue("@Department", department);
						cmd.Parameters.AddWithValue("@CreateDate", createDate.Ticks);
						cmd.Parameters.AddWithValue("@IsActive", isActive);

						cmd.ExecuteNonQuery();
					}
				}
				else
				{
					using (var cmd = new SQLiteCommand("UPDATE Project SET Name = @Name, Department = @Department, IsActive = @IsActive WHERE ProjectID = @ProjectID", conn))
					{
						cmd.CommandType = CommandType.Text;

						cmd.Parameters.AddWithValue("@ProjectID", projectID);
						cmd.Parameters.AddWithValue("@Name", projectName);
						cmd.Parameters.AddWithValue("@Department", department);
						cmd.Parameters.AddWithValue("@IsActive", isActive);

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

				using (var cmd = new SQLiteCommand("SELECT Project.ProjectID, Project.Name, Project.Department, LogSum.TotalMinutes FROM (SELECT ProjectID, SUM(minutes) AS TotalMinutes FROM Log WHERE EntryDate > @BeginDate AND EntryDate <= @EndDate GROUP BY ProjectID) AS LogSum INNER JOIN Project ON LogSum.ProjectID = Project.ProjectID ORDER BY Project.Department, Project.Name, Project.ProjectID", conn))
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
								Department = reader.GetString(idx++),
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

				using (var cmd = new SQLiteCommand("SELECT Log.LogID, Project.ProjectID, Project.Name, Project.Department, Log.UserName, Log.Minutes, Log.Description, Log.EntryDate FROM Log INNER JOIN Project ON Log.ProjectID = Project.ProjectID WHERE EntryDate > @BeginDate AND EntryDate <= @EndDate ORDER BY Log.EntryDate DESC, Project.Department, Project.Name, Project.ProjectID", conn))
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
								LogID = reader.GetInt64(idx++),
								ProjectID = reader.GetInt64(idx++),
								ProjectName = reader.GetString(idx++),
								Department = reader.GetString(idx++),
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

		public static List<Project> GetActiveProjects()
		{
			return TimeKeeperData.GetProjects(activeOnly: true);
		}
		public static List<Project> GetAllProjects()
		{
			return TimeKeeperData.GetProjects(activeOnly: false);
		}

		private static List<Project> GetProjects(bool activeOnly)
		{
			var projects = new List<Project>();

			using (var conn = new SQLiteConnection(TimeKeeperData.ConnectionString))
			{
				conn.Open();

				string query = "SELECT ProjectID, Name, Department, CreateDate, IsActive FROM Project";
				
				if (activeOnly)
				{
					query += " WHERE IsActive = 1";
				}

				using (var cmd = new SQLiteCommand(query, conn))
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
								DateCreated = new DateTime(reader.GetInt64(idx++)),
								IsActive = reader.GetBoolean(idx++)
							});
						}
					}
				}
			}
			
			return projects;
		}
	}
}
