namespace HomeworkOneLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greeting: ");
            string greetingWord = Console.ReadLine();

            Console.WriteLine(GetAnswer(greetingWord));
        }

        static string GetAnswer(string word)
        {
            string example = "hello";
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