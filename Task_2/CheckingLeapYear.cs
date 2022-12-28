using System;

namespace Task_2
{
    public class CheckingLeapYear
    {
        public string AnalyzeYear(int Year)
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
    }
}
