using HomeworkOneLibrary;
using HomeworkTwoLibrary;
using LessonOneLibrary;

namespace LessonOneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetNumbersAndSquare();

            Greeting();

            GetArrowN();

            GetTriangleN();

            GetRhomb();
        }

        // первое дз
        static void GetNumbersAndSquare()
        {
            Console.Write("Введите число: ");
            string? str = Console.ReadLine();
            int num = int.Parse(str);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

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

        // второе дз
        static void GetRhomb()
        {
            Console.Write("Введите число для построения ромба: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var diamondResult = HomeworkTwo.GetDiamond(num);

            Console.WriteLine(diamondResult);
        }

        static void GetTriangleN()
        {
            Console.Write("Введите число для построения треугольника: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var triangleResult = HomeworkTwo.GetTriangle(num);

            Console.WriteLine(triangleResult);
        }

        static void GetArrowN()
        {
            Console.Write("Введите число для построения стрелки: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var arrowResult = HomeworkTwo.GetArrow(num);

            Console.WriteLine(arrowResult);
        }

        // проверка
        static void CheckValueGreatThan(int value, string message,
            string paramName, int limit = 0)
        {
            if (value < limit)
            {
                throw new ArgumentException(message, paramName);
            }
        }
    }
}