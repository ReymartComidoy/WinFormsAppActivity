using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivity
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly string _connectionString;

        public SqlOrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveOrder(string email, decimal total)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Orders (Email, Total) VALUES (@e, @t)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@t", total);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
