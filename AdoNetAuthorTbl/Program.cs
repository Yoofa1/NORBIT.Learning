using Microsoft.Data.SqlClient;

namespace AdoNetAuthorTbl
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=.\SQLEXPRESS;Database=DemoBook;Trusted_Connection=True;TrustServerCertificate=True;";

            var queryString =
                "SELECT" +
                    "[name]" +
                "FROM [dbo].[author] ; ";

            var readers = new List<Reader>();

            using (var connection = new SqlConnection(connectionString) )
            {
                var command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            readers.Add(
                                new Reader()
                                {
                                    name = (string)reader[0]
                                });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            DisplayList(readers);
        }

        private static void DisplayList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Reader
    {
        public string name { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}