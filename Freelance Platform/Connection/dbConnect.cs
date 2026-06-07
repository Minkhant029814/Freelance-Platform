using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace Freelance_Platform.Connection
{
    internal class dbConnect
    {

        private readonly string connection = "server=localhost;user=root;password=029814;database=freelance;";


        // For Insert ,Update, Delete Method
        public bool ExecuteCommand(string query, MySqlParameter[] parameters)
        {
            using(MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //Getting Data from Database
        public DataTable GetData(string query, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                
            }
        }

        //Get single values like sum, count from database;
        public int GetScaler(string query, MySqlParameter[] parameters)
        {
            using(MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return Convert.ToInt32(cmd.ExecuteScalar());
                
            }
        }
    }
}
