using System;
namespace Codeforces
{
    public class ChatRoom
    {
        public static void Run()
        {
            string valid = "hello";
            int lv = valid.Length;

            string s = Console.ReadLine();
            int ls = s.Length;

            if (ls < lv)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0, j = 0; i < ls; i++)
            {
                j = s[i] == valid[j] ? j + 1 : j;

                if (j == lv)
                {
                    Console.WriteLine("YES");
                    return;
                }

                else if (ls - i < lv - j)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            // ls - i == lv - j == 1
            Console.WriteLine("NO");
        }
    }
}