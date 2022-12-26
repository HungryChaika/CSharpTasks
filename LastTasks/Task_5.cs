using System;
using System.Collections.Generic;

//Написать программу по выводу полной таблицы умножения от 1 до 10 в консоль.

namespace LastTasks
{
    public class Task_5
    {
        private int FreeSpaceOfCells = 4;
        private int LimitOfMultTable = 10;

        public void DrawMultTable()
        {
            for(int k = 0; k <= LimitOfMultTable; k++)
            {
                char[] SpaceBeforeNum = new char[FreeSpaceOfCells - Convert.ToString(k).Length];
                Array.Fill(SpaceBeforeNum, ' ');
                Console.Write($"{String.Join("", SpaceBeforeNum)}{k} |");
            }
            HorizontalLine();

            for (int i = 1; i <= LimitOfMultTable; i++)
            {
                for(int j = 0; j <= LimitOfMultTable; j++)
                {
                    int Space = i * ((j == 0) ? 1 : j);
                    char[] SpaceBeforeNum = new char[FreeSpaceOfCells - Convert.ToString(Space).Length];
                    Array.Fill(SpaceBeforeNum, ' ');
                    Console.Write($"{String.Join("", SpaceBeforeNum)}{Space} |");
                }
                HorizontalLine();
            }
        }

        private void HorizontalLine()
        {
            char[] HorizontalLine = new char[(FreeSpaceOfCells + 1) * (LimitOfMultTable + 1) + LimitOfMultTable];
            Array.Fill(HorizontalLine, '-');
            Console.Write($"\n{String.Join("", HorizontalLine)}|\n");
        }
    }
}
