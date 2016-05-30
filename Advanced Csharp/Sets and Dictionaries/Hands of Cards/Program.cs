using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<int>> persons = new Dictionary<string, HashSet<int>>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }

                string[] thisRow = input.Split(new[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string personName = thisRow[0];
                
                for (int i = 1; i < thisRow.Length; i++)
                {
                    char multiplyer = thisRow[i][thisRow[i].Length - 1];
                    string powerString = thisRow[i].Substring(0, thisRow[i].Length - 1);

                    int cardPoints = 0;

                    if (!int.TryParse(powerString, out cardPoints))
                    {
                        switch (powerString)
                        {
                            case "J":
                                cardPoints = 11;
                                break;
                            case "Q":
                                cardPoints = 12;
                                break;
                            case "K":
                                cardPoints = 13;
                                break;
                            case "A":
                                cardPoints = 14;
                                break;
                            default:
                                throw new ArgumentException("invalid multiplyer");
                        }
                    }

                    switch (multiplyer)
                    {
                        case 'C':
                            break;
                        case 'D':
                            cardPoints *= 2;
                            break;
                        case 'H':
                            cardPoints *= 3;
                            break;
                        case 'S':
                            cardPoints *= 4;
                            break;
                        default:
                            throw new ArgumentException("invalid multiplyer");
                    }

                    if (!persons.ContainsKey(personName))
                    {
                        persons[personName] = new HashSet<int>();
                    }

                    persons[personName].Add(cardPoints);
                }
            }
            foreach (var person in persons)
            {
                int sum = person.Value.Sum();
                Console.WriteLine($"{person.Key}: {sum}");
            }
        }
    }
}
