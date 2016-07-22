using System;
using System.Collections.Generic;
using System.Linq;

namespace border_Control
{
    class Program
    {
        static void Main()
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();
            string emigrants = Console.ReadLine();

            while (emigrants != "End")
            {
                string[] emigrantDetails = emigrants.Split();
                if (emigrantDetails.Length > 2)
                {
                    var human = new Citizen(emigrantDetails[0], int.Parse(emigrantDetails[1]), emigrantDetails[2]);
                    identifiables.Add(human);
                }
                else
                {
                    var robot = new Robot(emigrantDetails[0], emigrantDetails[1]);
                    identifiables.Add(robot);
                }
                emigrants = Console.ReadLine();
            }
            string fakeIds = Console.ReadLine();

            var detained = identifiables.Where(i => i.ID.EndsWith(fakeIds)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,detained));
        }
    }
}
