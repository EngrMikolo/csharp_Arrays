using System;

namespace ssg215_arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] teachers;
            teachers = new int[3];

            int[] students;
            students = new int[50];

            double[] doubleArray = new double[3];
            char[] charArray = new char[4];
            bool[] boolArray = new bool[2];
            string[] stringArray = new string[13];

            string[] fruitBasket = new string[4];
            fruitBasket[0] = "orange";
            fruitBasket[1] = "banana";
            fruitBasket[2] = "mango";
            fruitBasket[3] = "apple";

            Console.WriteLine(fruitBasket[0]);
            Console.WriteLine(fruitBasket[1]);
            Console.WriteLine(fruitBasket[2]);
            Console.WriteLine(fruitBasket[3]);

            foreach (string item in fruitBasket)
            {
                Console.WriteLine(item);
            }

            int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] names = new string[2, 2] { { "Mike", "Arinze" }, { "John", "Peter" } };

            int[,] figures = new int[3, 2];
            figures[0, 0] = 1;
            figures[0, 1] = 2;
            figures[1, 0] = 3;
            figures[1, 1] = 4;
            figures[2, 0] = 5;
            figures[2, 1] = 6;

            Console.WriteLine(figures[0, 0]);
            Console.WriteLine(figures[0, 1]);
            Console.WriteLine(figures[1, 0]);
            Console.WriteLine(figures[1, 1]);
            Console.WriteLine(figures[2, 0]);
            Console.WriteLine(figures[2, 1]);

        }
    }
}
