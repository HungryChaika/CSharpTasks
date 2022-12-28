using System;

namespace Task_1
{
    public class CalcPrimeNum
    {
        int QuantityOfNums;
        bool[] FlagsNums;
        int[] ValuesNums;

        public CalcPrimeNum(int QuantityOfNums)
        {
            this.QuantityOfNums = QuantityOfNums;
            FlagsNums = new bool[QuantityOfNums];
            ValuesNums = new int[QuantityOfNums];
        }

        public void FillingInArrays()
        {
            Array.Fill(FlagsNums, true);
            int Count = 1;
            while (Count <= ValuesNums.Length)
            {
                ValuesNums[Count - 1] = Count;
                Count++;
            }
        }

        public int[] CheckPrimeNums()
        {
            double LimitationOfCalculations = Math.Sqrt(QuantityOfNums);
            for (int i = 0; i < ValuesNums.Length; i++)
            {
                int Divisor = 2;
                int NumOfDivisors = 0;
                while (Divisor <= LimitationOfCalculations)
                {
                    if (ValuesNums[i] % Divisor == 0 && Divisor != ValuesNums[i])
                    {
                        NumOfDivisors++;
                    }
                    if (NumOfDivisors == 1 || ValuesNums[i] == 1)
                    {
                        FlagsNums[i] = false;
                        break;
                    }
                    Divisor++;
                }
            }
            int[] Answer = new int[Array.FindAll(FlagsNums, elem => elem == true).Length];
            int Count = 0;
            for (int i = 0; i < FlagsNums.Length; i++)
            {
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
