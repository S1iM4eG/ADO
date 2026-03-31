using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    class Scalar
    {
        private SqlConnection connection;

        public Scalar(SqlConnection connection)
        {
            this.connection = connection;
        }

        public object Execute(string cmd)
        {
            object value = null;
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            value = command.ExecuteScalar();
            connection.Close();
            return value;
        }
    }
}