using System;
using static System.Net.Mime.MediaTypeNames;

//Напишите сортировку для массива строк. Массив строк читать из файла.
//Программа должна вывести на экран массив отсортированных строк.
//Сортировку необходимо написать самому. Нельзя использовать встроенные методы Sort и OrderBy.

namespace Task_6
{
    class Programm
    {
        public static void Main(string[] args)
        {
            string Path = "../../../StringsArr.txt";
            string[] Text = File.ReadAllText(Path).Split("\n");
            Console.WriteLine("\nИзначальный массив:");
            PrintText(Text);
            MySort mySort = new MySort();
            mySort.SortText(Text);
            Console.WriteLine("\nОтсортированный массив:");
            PrintText(Text);
        }
        static void PrintText(string[] Text)
        {
            foreach (string Str in Text)
            {
                Console.WriteLine(Str);
            }
        }
    }
}