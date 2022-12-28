using System;

namespace Task_6
{
    public class MySort
    {
        public void SortText(string[] Text)
        {
            int IndexOfSelectedWord = 0;
            while (true)
            {
                bool FlagOfChanges = false;
                for (int i = IndexOfSelectedWord; i < Text.Length; i++)
                {
                    if (i != IndexOfSelectedWord)
                    {
                        int Pos = ComparisonOfTwoWords(Text[IndexOfSelectedWord], Text[i]);
                        if (Pos == 1)
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
            if (Word_1.Length - 1 < ComparisonDepth || Word_1[ComparisonDepth] < Word_2[ComparisonDepth])
            {
                return -1;
            }
            else if (Word_2.Length - 1 < ComparisonDepth || Word_1[ComparisonDepth] > Word_2[ComparisonDepth])
            {
                return 1;
            }
            else
            {
                return ComparisonOfTwoWords(Word_1, Word_2, ++ComparisonDepth);
            }
        }
    }
}
