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

        public DataTable AllProject()
        {
            string query = "Select ProjectTitle,Description,Budget,EndDate,Status from projects where ClientId = @clientId";

            MySqlParameter[] ps =
            {
                new MySqlParameter("@clientId",UserSession.ClientId)
            };

          return  dbconnect.GetData(query, ps);
        }
    }
}
