using System;

//Дана окружности с центром в точке (0, -1) и радиусом 2.
//Написать программу, которая получает на вход две координаты
//и проверяет находится ли точка в границах окружности.

namespace LastTasks
{
    public class Task_4
    {
        double X;
        double Y;

        public void InitCoords()
        {
            Console.Write("\nВведите координаты точки\n");
            while (true)
            {
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
        }

        public void AnalyzeCoords()
        {
            Console.Write("\nТочка" + ((X * X + (Y + 1) * (Y + 1) <= 4.0) ? " в " : " вне ") + "окружности.\n"); 
        }
    }
}
