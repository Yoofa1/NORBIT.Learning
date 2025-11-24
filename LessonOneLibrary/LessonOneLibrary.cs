namespace LessonOneLibrary
{

    /// <summary>
    /// Работает с числом, вводимым пользователем.
    /// Функции класса:
    ///     1. GetOddNumbers - возвращает строку неченых чисел
    ///     2. GetSquare - возвращает квадрат из "Х" со сторонами n 
    /// </summary>
    public static class WorkingWithNumbers
    {
        /// <summary>
        /// Проверяет числа от 1 до n на нечетность
        /// </summary>
        /// <param name="number">принимаемый аргумент</param>
        /// <returns>строку нечетных чисел</returns>
        public static string GetOddNumbers(int number)
        {
            string numbers = "";

            for (int i = 1; i <= number; i+=2)
            {
                numbers += i + ",";
            }

            numbers = numbers.Remove(numbers.Length - 1);

            return numbers;
        }

        /// <summary>
        /// Создает квадрат со сторонами n
        /// </summary>
        /// <param name="number">принимаемый аргумент</param>
        /// <returns>квадрат из "Х"</returns>
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