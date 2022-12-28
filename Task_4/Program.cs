using System;

//Дана окружности с центром в точке (0, -1) и радиусом 2.
//Написать программу, которая получает на вход две координаты
//и проверяет находится ли точка в границах окружности.

namespace Task_4
{
    class Programm
    {
        public static void Main(string[] args)
        {
            double X;
            double Y;
            while (true)
            {
                Console.Write("\nВведите координаты точки:\n");
                try
                {
                    Console.Write("\nХ = ");
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nY = ");
                    Y = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Console.Write("\nТочка" + ((X * X + (Y + 1) * (Y + 1) <= 4.0) ? " в " : " вне ") + "окружности.\n");
        }
    }
}