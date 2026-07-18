using Freelance_Platform.Connection;
using Freelance_Platform.model;
using Freelance_Platform.Session;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Freelance_Platform.Repositories
{
    internal class ProjectRepository
    {

        private readonly dbConnect dbconnect = new dbConnect();

       
        public bool PostProject(Project project)
        {

            try
            {

                string query = "Insert into projects (ClientId,ProjectTitle,Description,Budget,StartDate,EndDate,Status) values" +
                " (@clientId,@title,@desc,@budget,@startDate,@endDate,'PLANNING')";
                MySqlParameter[] ps =
                {
                new MySqlParameter("@clientId",UserSession.ClientId),
                new MySqlParameter("@title",project.ProjectTitle),
                new MySqlParameter("@desc",project.Description),
                new MySqlParameter("@budget",project.BaselineBudget),
                new MySqlParameter("@startDate",project.StartDate),
                new MySqlParameter("@endDate",project.EndDate),

            };

                return dbconnect.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public List<Project> AllProjectById()
        {
            string query = "Select ProjectTitle,Description,Budget,EndDate,Status from projects where ClientId = @clientId";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@clientId",UserSession.ClientId)
            };

          DataTable dt =  dbconnect.GetData(query, ps);
            List<Project> projects = new List<Project>();

            foreach(DataRow row in dt.Rows)
            {
                Project p = new Project
                {
                    ProjectTitle = row["ProjectTitle"].ToString(),
                    Description = row["Description"].ToString(),
                    BaselineBudget = Convert.ToDecimal(row["Budget"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    CurrentStatus = row["Status"].ToString(),
                };

                projects.Add(p);
                
            }

            return projects;
        }


       


        public List<Project> AllProject()
        {
            string query = "SELECT * FROM Projects WHERE STATUS IN ('PLANNING', 'ON_HOLD');";

            using (MySqlConnection conn = dbconnect.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
             
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                List<Project> projects = new List<Project>();

                foreach(DataRow row in dt.Rows)
                {
                    Project p = new Project
                    {
                        ProjectId = Convert.ToInt32(row["ProjectId"]),
                        ClientId = Convert.ToInt32(row["ClientId"]),
                        ProjectTitle = row["ProjectTitle"].ToString(),
                        Description = row["Description"].ToString(),
                        BaselineBudget = Convert.ToDecimal(row["Budget"]),
                        EndDate = Convert.ToDateTime(row["EndDate"]),
                        CurrentStatus = row["Status"].ToString()



                    };
                    projects.Add(p);

                };



                return projects;
            }


        }


        public bool ToggleProjectStatus(int projectId)
        {
            try
            {
               
                string query = @"UPDATE projects 
                         SET Status = CASE 
                            WHEN Status = 'PLANNING' THEN 'ON_HOLD' 
                            WHEN Status = 'ON_HOLD' THEN 'PLANNING' 
                            ELSE Status 
                         END 
                         WHERE ProjectId = @pid;";

                MySqlParameter[] ps = { new MySqlParameter("@pid", projectId) };

                return dbconnect.ExecuteCommand(query, ps);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
