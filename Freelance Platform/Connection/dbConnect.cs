using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace Freelance_Platform.Connection
{
    internal class dbConnect
    {

        private readonly string connection = "server=localhost;user=root;password=029814;database=freelance;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connection);
        }

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

        public bool ExecuteTransaction(List<string> queries, List<MySqlParameter[]> parameterList)
        {
            if (queries.Count != parameterList.Count) return false;

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < queries.Count; i++)
                            {
                                using (MySqlCommand cmd = new MySqlCommand(queries[i], conn, transaction))
                                {
                                    if (parameterList[i] != null)
                                    {
                                        cmd.Parameters.AddRange(parameterList[i]);
                                    }
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Transaction Failed " + ex.Message);
                }
            }
        }
    }
}
