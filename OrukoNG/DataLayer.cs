using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OrukoNG
{
    public class DataLayer
    {
        protected string connectionString = WebConfigurationManager.ConnectionStrings["Tunez"].ConnectionString;
        
        public List<string> GetName(string name)
        {
            List<string> result = new List<string>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Names FROM Tunes WHERE Names LIKE @letter + '%'";
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@letter", name);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        result.Add(dr["Names"].ToString());
                    }
                    dr.Close();
                }
                return result;
            }
        }
    }
}