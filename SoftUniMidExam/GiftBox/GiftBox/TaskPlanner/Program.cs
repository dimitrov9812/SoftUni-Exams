using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hoursNeeded = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command;
            int completedCount = 0;
            int incompletedCount = 0;
            int countDropped = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splittedInput = command.Split(' ');
                string toDo = splittedInput[0];
                switch (toDo)
                {
                    case "Complete":
                        int index = int.Parse(splittedInput[1]);
                        if(index >= 0 && index < hoursNeeded.Count)
                        {
                            hoursNeeded[index] = 0;
                        }
                        break;
                    case "Change":
                        index = int.Parse(splittedInput[1]);
                        int time = int.Parse(splittedInput[2]);
                        if (index >= 0 && index < hoursNeeded.Count)
                        {
                            hoursNeeded[index] = time;
                        }
                        break;
                    case "Drop":
                        index = int.Parse(splittedInput[1]);
                        if (index >= 0 && index < hoursNeeded.Count)
                        {
                            hoursNeeded.RemoveAt(index);
                            countDropped += 1;
                        }
                        break;
                    case "Count":
                        string type = splittedInput[1];
                        switch (type)
                        {
                            case "Completed":
                                foreach (var task in hoursNeeded)
                                {
                                    if(task == 0)
                                    {
                                        completedCount += 1;
                                    }
                                }
                                Console.WriteLine(completedCount);
                                break;
                            case "Incomplete":
                                foreach (var task in hoursNeeded)
                                {
                                    if (task != 0)
                                    {
                                        incompletedCount += 1;
                                    }
                                }
                                Console.WriteLine(incompletedCount);
                                break;
                            case "Dropped":
                                foreach (var task in hoursNeeded)
                                {
                                    if (task < 0)
                                    {
                                        countDropped += 1;
                                    }
                                }
                                Console.WriteLine(countDropped);
                                break;
                            default:
                                break;
                        }
                        break;
                }
                //Console.WriteLine(string.Join(" ",hoursNeeded));
            }
            foreach (var task in hoursNeeded)
            {
                if(task != 0 && task > 0)
                {
                    Console.Write(task+" ");
                }
            }
        }
    }
}
