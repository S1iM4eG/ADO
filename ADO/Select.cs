using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    class Select
    {
        private SqlConnection connection;

        public Select(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Execute(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
                Console.Write($"{reader.GetName(i)}\t");
            Console.WriteLine();
            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
            }
            reader.Close();
            connection.Close();
        }
    }
}