using Microsoft.Data.SqlClient;
using System.Data;

namespace InlämningDatabas1.Data
{
    public static class BlocketContext
    {
        // For security only use _connString in this class
        private static string _connString = "Data Source=localhost;Initial " +
            "Catalog=BlocketDB;Integrated Security=SSPI;TrustServerCertificate=True;";


        // Handels select, returns DataTable
        public static DataTable ExecuteQueryReturnTable(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);


                // Parameter input
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }


                DataTable result = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                // Run query, returns result as a DataTable
                adapter.Fill(result);


                return result;
            }
        }


        // Mehtod to handle insert, update and delete
        // Doesn't return anything, void
        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);


                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }


                // Execute query, no return
                cmd.ExecuteNonQuery();
            }
        }
    }
}
