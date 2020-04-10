
using System;

namespace Roma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int count = Convert.ToInt32(Console.ReadLine());

            WordsLists wordsLists = new WordsLists(count);
            wordsLists.Lists();
            wordsLists.WordsAnalysis();
        }
    }
}
