namespace HomeworkTwoLibrary
{
    /// <summary>
    /// Класс, в котором реализованно три функции:
    ///     1. GetDiamond - формирует ромб
    ///     2. GetTriangle - формирует треугольник
    ///     3. GetArrow - формирует стрелку
    /// </summary>
    public static class HomeworkTwo
    {
        /// <summary>
        /// Формирует ромб со сторонами N
        /// </summary>
        /// <param name="value"></param>
        /// <returns>ромб</returns>
        public static string GetDiamond(int value)
        {
            if (value % 2 == 0)
            {
                value++;
            }

            string diamond = "";
            int half = value / 2;

            for (int i = 0; i <= half; i++)
            {
                diamond += new string(' ', half - i);
                diamond += "X";

                if (i > 0)
                {
                    diamond += new string(' ', 2 * i - 1);
                    diamond += "X";
                }

                diamond += "\n";
            }

            for (int i = half - 1; i >= 0; i--)
            {
                diamond += new string(' ', half - i);
                diamond += "X";

                if (i > 0)
                {
                    diamond += new string(' ', 2 * i - 1);
                    diamond += "X";
                }

                diamond += "\n";
            }

            return diamond;
        }

        /// <summary>
        /// Формирует равносторонний треугольник
        /// </summary>
        /// <param name="value"></param>
        /// <returns>треугольник</returns>
        public static string GetTriangle(int value)
        {
            string triangle = "";

            for (int i = 0; i < value; i++)
            {
                triangle += "X";

                if (i > 0 && i != value - 1)
                {
                    triangle += new string(' ', i - 1);
                    triangle += "X";
                }
                else if (i == value - 1)
                {
                    triangle += new string('X', i);
                }

                triangle += "\n";
            }

            return triangle;
        }

        /// <summary>
        /// Формирует стрелку
        /// </summary>
        /// <param name="value"></param>
        /// <returns>стрелка</returns>
        public static string GetArrow(int value)
        {
            string arrow = "";
            int half = value / 2;

            for (int i = 0; i <= half; i++)
            {
                arrow += "X";

                if (i > 0)
                {
                    arrow += new string(' ', i - 1);
                    arrow += "X";
                }

                arrow += "\n";
            }

            for (int i = half - 1; i >= 0; i--)
            {
                arrow += "X";

                if (i > 0)
                {
                    arrow += new string(' ', i - 1);
                    arrow += "X";
                }

                arrow += "\n";
            }

            return arrow;
        }
    }
}
