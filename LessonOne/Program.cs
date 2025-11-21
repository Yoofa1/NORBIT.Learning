using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string str = Console.ReadLine();
        int num = Int32.Parse(str);

        Console.WriteLine(GetOddNumbers(num));
        Console.WriteLine(GetSquare(num));
    }

    static string GetOddNumbers(int num)
    {
        string numbers = "";

        for (int i = 0; i <= num; i++)
        {
            if (i % 2 != 0)
            {
                numbers += i + ",";
            }
        }

        numbers = numbers.Remove(numbers.Length - 1);

        return numbers;
    }

    static string GetSquare(int num)
    {
        string str = string.Empty;

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                if ((i == 0 || i == num - 1) || (j == 0 || j == num - 1))
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