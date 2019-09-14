using System;

namespace Codeforces
{
    public class WordCapitalization
    {
        public static void Run() 
        {
            string word = Console.ReadLine();
            Console.WriteLine(word[0].ToString().ToUpper() + word.Substring(1));
        }
    }
}