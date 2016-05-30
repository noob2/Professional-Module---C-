using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] args = input.Split('=', ' ');
                string ip = args[1];
                string user = args[5];

                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                    users[user].Add(ip, 1);
                }
                else
                {
                    if (users[user].ContainsKey(ip))
                    {
                        users[user][ip]++;
                    }
                    else
                    {
                        users[user].Add(ip, 1);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: ");
                Console.WriteLine($"{string.Join(", ", user.Value.Select(kv => kv.Key + " => " + kv.Value))}.");
            }
        }
    }
}
