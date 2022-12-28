using System;

//Написать программу по переворачиванию стрелочки.
//В консоли должна отображаться нарисованная символами стрелочка
//в зависимости от того, какая стрелочка нажата на клавиатуре.
//В ходе работы программы нажатия должны считываться постоянно и стрелочка должна меняться.
//Консоль должна очищаться перед каждым отображением.

namespace Task_3
{
    class Programm
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n(Нажмите на клавишу стрелки или на Esc)\n");
                ConsoleKeyInfo Arrow = Console.ReadKey();
                switch (Arrow.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.WriteLine("\n\t<-");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.WriteLine("\n\t" + char.ConvertFromUtf32(0x2192));
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Console.WriteLine("\n\t" + char.ConvertFromUtf32(0x2191));
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("\n\t" + char.ConvertFromUtf32(0x2193));
                        break;
                }
                if (Arrow.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}