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
        public static string GetAnswer(string word, string example)
        {
            int indexExample = 0;

            foreach (char c in word)
            {
                if (c == example[indexExample])
                {
                    indexExample++;
                }

                if (indexExample == example.Length)
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}