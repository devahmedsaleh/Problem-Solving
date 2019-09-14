using System;
namespace Codeforces
{
    public class NextRound
    {
        public static void Run()
        {
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            int counter = 0;

            int k = int.Parse(line1[1]);
            int kScore = int.Parse(line2[k - 1]);

            if (k == 1 && kScore == 0)
            {
                counter = 0;
            }
            else
            {
                Array.ConvertAll(line2, new Converter<string, int>(str =>
                {
                    int num = int.Parse(str);
                    return (num != 0 && num >= kScore) ? counter++ : -1;
                }));
            }

            Console.WriteLine(counter);
        }
    }
}

