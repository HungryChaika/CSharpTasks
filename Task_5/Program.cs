using System;

//Написать программу по выводу полной таблицы умножения от 1 до 10 в консоль.

namespace Task_5
{
    class Programm
    {
        public static void Main(string[] args)
        {
            int FreeSpaceOfCells = 4;
            int LimitOfMultTable = 10;
            for (int i = 0; i <= LimitOfMultTable; i++)
            {
                for (int j = 0; j <= LimitOfMultTable; j++)
                {
                    int Space = ((i == 0 && j == 0) ? 0 : ((i == 0) ? 1 : i)) * ((j == 0) ? 1 : j);
                    char[] SpaceBeforeNum = new char[FreeSpaceOfCells - Convert.ToString(Space).Length];
                    Array.Fill(SpaceBeforeNum, ' ');
                    Console.Write($"{String.Join("", SpaceBeforeNum)}{Space} |");
                }
                HorizontalLine(FreeSpaceOfCells, LimitOfMultTable);
            }
        }
        static void HorizontalLine(int FreeSpaceOfCells, int LimitOfMultTable)
        {
            char[] HorizontalLine = new char[(FreeSpaceOfCells + 1) * (LimitOfMultTable + 1) + LimitOfMultTable];
            Array.Fill(HorizontalLine, '-');
            Console.Write($"\n{String.Join("", HorizontalLine)}|\n");
        }
    }
}