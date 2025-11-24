using HomeworkOneLibrary;
using LessonOneLibrary;
using System;

namespace LessonOneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumbersAndSquare();

            Greeting();
        }

        static void GetNumbersAndSquare()
        {
            Console.Write("Введите число: ");
            string? str = Console.ReadLine();
            int num = int.Parse(str);

            var oddNumbersResult = WorkingWithNumbers.GetOddNumbers(num);

            var squareResult = WorkingWithNumbers.GetSquare(num);

            Console.WriteLine(oddNumbersResult + "\n" + squareResult);
        }

        static void Greeting()
        {
            Console.Write("Введите приветсвие: ");
            string? greetingWord = Console.ReadLine();

            var greetingResult = WorkingWithGreeting.GetAnswer(greetingWord, "hello");

            Console.WriteLine(greetingResult);
        }
    }
}