using HomeworkOneLibrary;
using HomeworkTwoLibrary;
using LessonOneLibrary;

namespace LessonOneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputOddNumbers();

            OutputSquare();

            OutputAnswer();

            OutputArrow();

            OutputTriangle();

            OutputRhomb();
        }

        /// <summary>
        /// Вывод строки нечетных чисел
        /// </summary>
        static void OutputOddNumbers()
        {
            Console.Write("Введите число: ");
            string? str = Console.ReadLine();
            int num = int.Parse(str);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var oddNumbersResult = WorkingWithNumbers.GetOddNumbers(num);

            Console.WriteLine(oddNumbersResult);
        }

        /// <summary>
        /// Вывод квадрата с заданной пользователем стороной
        /// </summary>
        static void OutputSquare()
        {
            Console.Write("Введите число: ");
            string? str = Console.ReadLine();
            int num = int.Parse(str);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var squareResult = WorkingWithNumbers.GetSquare(num);

            Console.WriteLine(squareResult);
        }

        /// <summary>
        /// Вывод ответа проверки приветсвия (True/False)
        /// </summary>
        static void OutputAnswer()
        {
            Console.Write("Введите приветсвие: ");
            string? greetingWord = Console.ReadLine();

            var greetingResult = WorkingWithGreeting.GetAnswer(greetingWord, "hello");

            Console.WriteLine(greetingResult);
        }

        /// <summary>
        /// Вывод ромба 
        /// </summary>
        static void OutputRhomb()
        {
            Console.Write("Введите число для построения ромба: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var diamondResult = HomeworkTwo.GetDiamond(num);

            Console.WriteLine(diamondResult);
        }

        /// <summary>
        /// Вывод треугольника с заданной пользователем стороной
        /// </summary>
        static void OutputTriangle()
        {
            Console.Write("Введите число для построения треугольника: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var triangleResult = HomeworkTwo.GetTriangle(num);

            Console.WriteLine(triangleResult);
        }

        /// <summary>
        /// Вывод стрелки
        /// </summary>
        static void OutputArrow()
        {
            Console.Write("Введите число для построения стрелки: ");
            string? numString = Console.ReadLine();
            int num = int.Parse(numString);

            CheckValueGreatThan(num, "Ожидается значение > 0", nameof(num));

            var arrowResult = HomeworkTwo.GetArrow(num);

            Console.WriteLine(arrowResult);
        }

        /// <summary>
        /// Проверяем, что <paramref name="value"/> >= 0.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <param name="limit"></param>
        /// <exception cref="ArgumentException"></exception>
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