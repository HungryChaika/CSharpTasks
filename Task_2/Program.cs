using System;

//Напишите программу по вычислению того является ли введённый год високосным.
//Ввод: год в формате YYYY.
//Вывод: сообщение о том, является ли год високосным

namespace Task_2
{
    class Programm
    {
        public static void Main(string[] args)
        {
            int Year;
            while (true)
            {
                Console.Write("\nВведите год в формате ХХХХ: ");
                try
                {
                    int item = Convert.ToInt32(Console.ReadLine());
                    if (item >= 1000 && item <= 9999)
                    {
                        Year = item;
                        break;
                    }
                }
                catch
                {
                    Console.Write("Просьба вводить число следуя условиям\nЧисло:");
                }
            }
            CheckingLeapYear checkingLeapYear = new CheckingLeapYear();
            string Answer = checkingLeapYear.AnalyzeYear(Year);
            Console.Write($"\nГод {Year} {Answer};\n");
        }
    }
}