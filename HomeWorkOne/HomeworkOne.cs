namespace HomeworkOneLibrary
{
    /// <summary>
    /// Работает с вводимым привествием пользователя
    /// </summary>
    public static class WorkingWithGreeting
    {
        /// <summary>
        /// Проверяет вводимое слово пользователем на правильность написание.
        /// Слово проверки - "hello"
        /// </summary>
        /// <param name="word"></param>
        /// <returns>YES/NO</returns>
        public static bool GetAnswer(string word, string example)
        {
            CheckValueGreaterThan(word, "Ожидается, что строка не будет пустой", nameof(word));
            CheckValueGreaterThan(example, "Ожидается, что строка не будет пустой", nameof(example));

            string checkWord = word.ToLower();
            int indexExample = 0;

            foreach (char c in checkWord)
            {
                if (c == example[indexExample])
                {
                    indexExample++;
                }

                if (indexExample == example.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public static void CheckValueGreaterThan(string word, string message,
            string paramName, int limit = 0)
        {
            if (word.Length <= limit)
            {
                throw new ArgumentException(message, paramName);
            }
        }

    }
}