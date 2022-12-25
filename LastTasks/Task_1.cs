using System;

//Prime Number.
//Напишите программу по определению для проверки числа на простоту.
//Ввод: целое число. 0 ≤ n ≤10000
//Вывод: если число простое, то вывести на экран консоли "Число <число> простое!". Иначе: "Число <число> не является простым".

namespace LastTasks
{
    public class Task_1
    {
        private int _QuantityOfNums = -1;
        public int QuantityOfNums
        {
            get => _QuantityOfNums;
        }
        private bool[] FlagsNums;
        private int[] ValuesNums { get; set; }

        public void ReadNumberFromConsole()
        {
            Console.Write("\nВведите целое число >= 0 и <= 10000\nЧисло: ");
            while (true)
            {
                try
                {
                    string elem = Console.ReadLine();
                    int item = Convert.ToInt32(elem);
                    if (item >= 0 && item <= 10000)
                    {
                        _QuantityOfNums = item;
                        break;
                    }
                    else
                    {
                        Console.Write("Число должно быть целым, а так же >= 0 и <= 10000\nЧисло: ");
                    }
                }
                catch
                {
                    Console.Write("Просьба вводить число следуя условиям\nЧисло:");
                }
            }
        }

        public void FillingInArrays()
        {
            FlagsNums = new bool[_QuantityOfNums];
            ValuesNums = new int[_QuantityOfNums];
            Array.Fill(FlagsNums, true);
            int Count = 1;
            while (Count <= ValuesNums.Length)
            {
                ValuesNums[Count - 1] = Count;
                Count++;
            }
        }

        public void CheckPrimeNums()
        {
            double LimitationOfCalculations = Math.Sqrt(_QuantityOfNums);
            for (int i = 0; i < ValuesNums.Length; i++)
            {
                int Count = 2;
                int NumOfDivisors = 0;
                while (Count <= LimitationOfCalculations)
                {
                    if (ValuesNums[i] % Count == 0 && Count != ValuesNums[i])
                    {
                        NumOfDivisors++;
                    }
                    if (NumOfDivisors == 1 || ValuesNums[i] == 1)
                    {
                        FlagsNums[i] = false;
                        break;
                    }                 
                    Count++;
                }
            }
            int[] Answer = FillingAnswerArr();
            Console.WriteLine("Ответ:");
            WriteMatrix(Answer);
        }

        private void WriteMatrix<T>(T[] Elem)
        {
            for(int i = 0; i < Elem.Length; i++)
            {
                string СommaOrLastPosition = (i == Elem.Length - 1) ? "." : ", ";
                Console.Write($"{Elem[i]} {СommaOrLastPosition}");
            }
        }

        private int[] FillingAnswerArr()
        {
            int[] Answer = new int[Array.FindAll(FlagsNums, elem => elem == true).Length];
            int Count = 0;
            for (int i = 0; i < FlagsNums.Length; i++) {
                if (FlagsNums[i])
                {
                    Answer[Count] = ValuesNums[i];
                    Count++;
                }
            }
            return Answer;
        }
    }
}
