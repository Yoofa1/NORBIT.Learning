using Microsoft.Data.SqlClient;

namespace AdoNetHomework
{
    class Program
    {
        static void Main(string[] args)
        {                
            const string connectionString = @"Server=.\SQLEXPRESS;Database=DemoBook;Trusted_Connection=True;TrustServerCertificate=True;";

            var queryString =
                "SELECT" +
                    "[title]" +
                    ", [author]" +
                    ", [publisher]" +
                    ", [age_limit]" +
                    ", [genre]" +
                "FROM [dbo].[books_src]" +
                "ORDER BY title ;";

            var readers = new List<Reader>();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            readers.Add(
                                new Reader()
                                {
                                    title = (string)reader[0],
                                    author = (string)reader[1],
                                    publisher = (string)reader[2],
                                    age_limit = GetInt(reader[3]),
                                    genre = (string)reader[4]
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

        public static int? GetInt(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            return (int)value;
        }
    }

    class Reader
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int? age_limit { get; set; }
        public string genre { get; set; }

        public override string ToString()
        {
            return $"{title}, {author}, {publisher}, {age_limit}, {genre}";
        }
    }
}
