using System;

//Напишите программу по вычислению того является ли введённый год високосным.
//Ввод: год в формате YYYY.
//Вывод: сообщение о том, является ли год високосным 

namespace LastTasks
{
    public class Task_2
    {
        private int Year { get; set; }

        public void ReadYearFromConsole()
        {
            Console.Write("\nВведите год в формате ХХХХ: ");
            while (true)
            {
                try
                {
                    int item = Convert.ToInt32(Console.ReadLine());
                    if (item >= 1000 && item <= 9999)
                    {
                        Year = item;
                        break;
                    }
                    else
                    {
                        Console.Write("\nГод должно быть в формате ХХХХ, введите заново: ");
                    }
                }
                catch
                {
                    Console.Write("Просьба вводить число следуя условиям\nЧисло:");
                }
            }
        }

        private string AnalyzeYear()
        {
            string Answer = (Year % 4 == 0)
                ? ((Year % 100 == 0)
                    ? ((Year % 400 == 0)
                        ? "високосный"
                        : "не високосный")
                    : "Високосный")
                : "Не високосный";
            return Answer;
        }

        public void ViewAnswer()
        {
            string Answer = AnalyzeYear();
            Console.Write($"Год {Year} {Answer};\n");
        }
    }
}
