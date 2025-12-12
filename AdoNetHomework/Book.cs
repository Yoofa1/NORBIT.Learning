using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomework
{
    /// <summary>
    /// Класс содержит названия книг, их авторов, названия издательств,
    /// возрастные ограничения и жанр
    /// </summary>
    internal class Reader
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
