using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    class Program
    {
        static void Main()
        {
            List<Human> humans = new List<Human>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] humanInfo = Console.ReadLine().Split();

                string name = humanInfo[0];
                int age = int.Parse(humanInfo[1]);

                if (humanInfo.Length > 3)
                {
                    string id = humanInfo[2];
                    string birthdate = humanInfo[3];
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    humans.Add(citizen);
                }
                else
                {
                    string group = humanInfo[2];
                    Rebel rebel = new Rebel(name, age, group);
                    humans.Add(rebel);
                }
            }
            string buyer = Console.ReadLine();
            while (buyer != "End")
            {//we check for null befor BuyFood()
                humans.Find(h => h.Name == buyer)?.BuyFood();
                buyer = Console.ReadLine();
            }
            int totalFoodBought = humans.Sum(human => human.Food);
            Console.WriteLine(totalFoodBought);
        }
    }
}
