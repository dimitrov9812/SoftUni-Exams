using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split(' ').ToList();
            string command;
            while((command=Console.ReadLine()) !="Print")
            {
                string[] splittedInput = command.Split(' ');
                string action = splittedInput[0];
                switch (action)
                {
                    case "Join":
                        string name = splittedInput[1];
                        if (!frogNames.Contains(name))
                        {
                            frogNames.Add(name);
                        }
                        break;
                    case "Jump":
                        name = splittedInput[1];
                        int index = int.Parse(splittedInput[2]);
                        if (!frogNames.Contains(name))
                        {
                            if (index >= 0 && index < frogNames.Count)
                            {
                                frogNames.Insert(index, name);
                            }
                        }
                        break;
                    case "Dive":
                        index = int.Parse(splittedInput[1]);
                        if (index >= 0 && index < frogNames.Count)
                        {
                            frogNames.RemoveAt(index);
                        }
                        break;
                    case "First":
                        int count = int.Parse(splittedInput[1]);
                        if(count > frogNames.Count)
                        {
                            Console.WriteLine(string.Join(" ",frogNames));
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(frogNames[i] + " ");
                            }
                        }
                        break;
                    case "Last":
                        count = int.Parse(splittedInput[1]);
                        if (count > frogNames.Count)
                        {
                            Console.WriteLine(string.Join(" ", frogNames));
                        }
                        else
                        {
                            int startPoint = (frogNames.Count - 1) - count+1;
                            for (int i = startPoint; i < frogNames.Count; i++)
                            {
                                Console.Write(frogNames[i] + " ");
                            }
                                Console.WriteLine( );
                        }
                        break;
                    case "Print":
                        string additionalCommad = splittedInput[1];
                        switch (additionalCommad)
                        {
                            case "Normal":
                                Console.WriteLine("Frogs: " + string.Join(" ", frogNames));
                                Environment.Exit(0);
                                break;
                            case "Reversed":
                                frogNames.Reverse();
                                Console.WriteLine("Frogs: "+string.Join(" ", frogNames));
                                Environment.Exit(0);
                                break;
                        } 
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
