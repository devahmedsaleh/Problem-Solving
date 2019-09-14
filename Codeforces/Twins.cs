using System;
namespace Codeforces
{
    public static class Twins
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');

            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine(line[0] == line[1] ? 2 : 1);
            }
            else
            {
                int sum = 0, sum1 = 0, sum2 = 0;

                int[] coins = Array.ConvertAll(line, int.Parse);
                Array.ForEach(coins, c => sum += c);
                //Array.Reverse(coins);
                Array.Sort(coins, (a, b) => b.CompareTo(a));

                for (int i = 0; i < n; i++)
                {
                    sum1 += coins[i];
                    sum2 = sum - sum1;

                    if (sum1 > sum2)
                    {
                        Console.WriteLine(i + 1);
                        return;
                    }
                }
            }
        }
    }
}
