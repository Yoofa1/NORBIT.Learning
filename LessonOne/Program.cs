using LessonOneLibrary;
using System;

namespace LessonOneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int num = Int32.Parse(str);

            var oddNumbersResult = WorkingWithNumbers.GetOddNumbers(num);

            var squareResult = WorkingWithNumbers.GetSquare(num);

            Console.WriteLine(oddNumbersResult + "\n" + squareResult);
        }
    }
}