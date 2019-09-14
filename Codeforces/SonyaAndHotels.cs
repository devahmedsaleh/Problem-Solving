using System;

namespace Codeforces
{
    public class SonyaAndHotels
    {
        public static void Run()
        {
            const int MIN_CITIES = 2;
            int cities = 0;

            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');

            int n = int.Parse(line1[0]);
            int d = int.Parse(line1[1]);
            int[] x = Array.ConvertAll(line2, int.Parse);

            for (int i = 0; i < n - 1; i++)
            {
                int coordDiff = x[i + 1] - x[i];
                int minValidDiff = 2 * d;

                if (coordDiff >= minValidDiff)
                {
                    if (coordDiff == minValidDiff)
                    {
                        cities++;
                    }
                    else
                    {
                        cities += 2;
                    }
                }
            }

            Console.WriteLine(MIN_CITIES + cities);
        }
    }
}
