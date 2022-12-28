using System;

//Напишите программу по определению для проверки числа на простоту.
//Ввод: целое число. 0 ≤ n ≤10000
//Вывод: если число простое, то вывести на экран консоли "Число <число> простое!". Иначе: "Число <число> не является простым".

namespace Task_1
{
    class Programm
    {
        public static void Main(string[] args)
        {
            int QuantityOfNums = -1;
            while (true)
            {
                Console.Write("\nВведите целое число >= 0 и <= 10000\nЧисло: ");
                try
                {
                    string? elem = Console.ReadLine();
                    int item = Convert.ToInt32(elem);
                    if (item >= 0 && item <= 10000)
                    {
                        QuantityOfNums = item;
                        break;
                    }
                }
                catch
                {
                    Console.Write("Просьба вводить число следуя условиям.");
                }
            }
            CalcPrimeNum calcPrimeNum = new CalcPrimeNum(QuantityOfNums);
            calcPrimeNum.FillingInArrays();
            int[] Answer = calcPrimeNum.CheckPrimeNums();
            Console.WriteLine("\nОтвет:");
            WriteMatrix(Answer);

        }
        static void WriteMatrix<T>(T[] Elem)
        {
            for (int i = 0; i < Elem.Length; i++)
            {
                string СommaOrLastPosition = (i == Elem.Length - 1) ? ".\n" : ", ";
                Console.Write($"{Elem[i]} {СommaOrLastPosition}");
            }
        }
    }
}