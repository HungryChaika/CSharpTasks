using System;
using System.Text;

//Напишите сортировку для массива строк. Массив строк читать из файла.
//Программа должна вывести на экран массив отсортированных строк.
//Сортировку необходимо написать самому. Нельзя использовать встроенные методы Sort и OrderBy.

namespace LastTasks
{
    public class Task_6
    {
        string Path = "../../../StringsArr.txt";
        string[] Text;

        public void Init()
        {
            Text = File.ReadAllText(Path).Split("\n");
            Console.WriteLine("\nИзначальный массив:");
            foreach ( string Str in Text)
            {
                Console.WriteLine(Str);
            }
        }
        public void SortText()
        {
            Console.WriteLine("\nРезультат:\n");
            int IndexOfSelectedWord = 0;
            while (true)
            {
                bool FlagOfChanges = false;
                for (int i = IndexOfSelectedWord; i < Text.Length; i++)
                {
                    if (i != IndexOfSelectedWord)
                    {
                        int Pos = ComparisonOfTwoWords(Text[IndexOfSelectedWord], Text[i]);
                        if(Pos == 1)
                        {
                            FlagOfChanges = true;
                            string Elem = Text[IndexOfSelectedWord];
                            Text[IndexOfSelectedWord] = Text[i];
                            Text[i] = Elem;
                        }
                    }
                }
                if (!FlagOfChanges)
                {
                    Console.WriteLine("\nОтсортированный массив:");
                    foreach (string Str in Text)
                    {
                        Console.WriteLine(Str);
                    }
                    break;
                }
                IndexOfSelectedWord++;
                if (IndexOfSelectedWord == Text.Length)
                {
                    IndexOfSelectedWord = 0;
                }
            }
        }

        private int ComparisonOfTwoWords(string Word_1, string Word_2, int ComparisonDepth = 0)
        {
            if (Word_1.Length - 1 < ComparisonDepth)
            {
                return -1;
            }
            if (Word_2.Length - 1 < ComparisonDepth)
            {
                return 1;
            }
            if (Word_1[ComparisonDepth] < Word_2[ComparisonDepth])
            {
                return -1;
            }
            else if (Word_1[ComparisonDepth] > Word_2[ComparisonDepth])
            {
                return 1;
            }
            else if (Word_1[ComparisonDepth] == Word_2[ComparisonDepth])
            {
                return ComparisonOfTwoWords(Word_1, Word_2, ++ComparisonDepth);
            }
            return 0;
        }
    }
}
