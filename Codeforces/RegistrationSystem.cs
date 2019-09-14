using System;
using System.Collections.Generic;

namespace Codeforces
{
    public static class RegistrationSystem
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] output = new string[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (dict.ContainsKey(name))
                {
                    output[i] = name + dict[name];
                    dict[name]++;
                    continue;
                }
                dict.Add(name, 1);
                output[i] = "OK";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(output[i]);
            }

        }
    }
}