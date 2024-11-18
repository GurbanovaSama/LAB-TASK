using AcademyDB.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyDB
{
   public static class SqlQueries
    {
        public static void InsertData(string command)
        {
            using (SqlConnection connection = new SqlConnection(ExtensionSql.connectionString))
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(command, connection);
                int result = insertCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                else
                {
                    Console.WriteLine("Problem occured");
                }

            }
        }

       

        public static void GetData (string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ExtensionSql.connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    Console.WriteLine(item["Id"] + " " + item["Name"]);
                }
            }
        }

        public static void DeleteData(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ExtensionSql.connectionString))
            {
                sqlConnection.Open();
                SqlCommand deleteCommand = new SqlCommand(command, sqlConnection);
                int result = deleteCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data deleted");
                }
                else
                {
                    Console.WriteLine("Problem occured");
                }
            }
        }

        public static void UpdateData(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ExtensionSql.connectionString))
            {
                sqlConnection.Open();
                SqlCommand updateCommand = new SqlCommand(command, sqlConnection);
                int result = updateCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Data deleted");
                }
                else
                {
                    Console.WriteLine("Problem occured");
                }
            }
        }
    }
}
