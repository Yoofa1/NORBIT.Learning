namespace LessonOneLibrary
{
    public static class WorkingWithNumbers
    {
        public static string GetOddNumbers(int number)
        {
            string numbers = "";

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    numbers += i + ",";
                }
            }

            numbers = numbers.Remove(numbers.Length - 1);

            return numbers;
        }

        public static string GetSquare(int number)
        {
            string str = string.Empty;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if ((i == 0 || i == number - 1) || (j == 0 || j == number - 1))
                    {
                        str += "X ";
                    }
                    else
                    {
                        str += "  ";
                    }
                }

                str += "\n";
            }

            return str;
        }
    }
}