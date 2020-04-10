using System;
using System.Collections.Generic;
using System.Text;

namespace Roma
{
    class WordsLists
    {
        int count;
        public List<string> list1 = new List<string>();
        public List<string> list2 = new List<string>();
        public WordsLists(int count)
        {
            this.count = count;
        }

        public void Lists()
        {
            for (int i = 0; i < count; i++)
            {
                string words = Console.ReadLine();

                string[] two_words = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                list1.Add(two_words[0]);
                list2.Add(two_words[1]);
            }
        }

        public void WordsAnalysis()
        {
            List<string> trueOrFalse = new List<string>();
            for (int i = 0; i < count; i++)
            {
                char[] array1 = list1[i].ToCharArray();
                char[] array2 = list2[i].ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);

                if (array1.Length == array2.Length)
                {
                    for (int j = 0; j < array1.Length; j++)
                    {
                        if (array1[j] == array2[j])
                        {
                            if (j == array1.Length - 1)
                                trueOrFalse.Add("YES");
                        }
                        else
                        {
                            trueOrFalse.Add("NO");
                            break;
                        }
                    }
                }

                else
                {
                    trueOrFalse.Add("NO");
                    continue;
                }
            }

            foreach(string t in trueOrFalse)
                Console.WriteLine(t);

        }

    }
}
