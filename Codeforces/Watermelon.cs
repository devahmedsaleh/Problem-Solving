using System;
namespace Codeforces
{
    public class Watermelon
    {
        public static void Run()
        {
            const int MIN_EVEN_DIVISION = 2;

            int weight = int.Parse(Console.ReadLine());
            int division = weight - MIN_EVEN_DIVISION;

            if (division > 0 && (division % 2) == 0)
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }
        }
    }
}