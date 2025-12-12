using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace ADOsql
{
    class Program
    {
        const string connectionString = @"Server=.\SQLEXPRESS;Database=DemoBook;Trusted_Connection=True;TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            var queryString =
                "SELECT " +
                    "[Name]" +
                    ", [Surname]" +
                "FROM [dbo].[employee] ";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                #region correct params sending
                //"WHERE Class > @classValue " +
                //command.Parameters.AddWithValue("@classValue", classValue);
                #endregion

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader[0], reader[1]);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
//#endregion

            return;
        }
    }
}

// Data Source=LAPTOP-IHIPN5K1\SQLEXPRESS;Integrated Security=True;Persist Security 