using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static SqlConnection connection;
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MoviesPV_522;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Console.WriteLine(connection_string);
            connection = new SqlConnection(connection_string);

            Select select = new Select(connection);
            Scalar scalar = new Scalar(connection);
            Console.WriteLine($"Количество записей: {scalar.Execute("SELECT COUNT(*) FROM Directors")}");
            select.Execute("SELECT * FROM Movies");
        }

        //static void Select(string cmd)
        //{
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    for (int i = 0; i < reader.FieldCount; i++)
        //        Console.Write($"{reader.GetName(i)}\t");
        //    Console.WriteLine();
        //    while (reader.Read())
        //    {
        //        Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");


        //    }
        //    reader.Close();
        //    connection.Close();
        //}
        //static object Scalar(string cmd)
        //{
        //    object value = null;
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    value = command.ExecuteScalar();
        //    connection.Close();
        //    return value;
        //}
    }
}
