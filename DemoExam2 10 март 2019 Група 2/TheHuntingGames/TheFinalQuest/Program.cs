using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] splittedCommand = command.Split(' ').ToArray();
                string action = splittedCommand[0];

                //Delete - Index
                switch (action)
                {
                    case "Delete":
                        int index = int.Parse(splittedCommand[1]) + 1;
                        if(index>=0 && index < words.Count)
                        {
                            words.RemoveAt(index);
                        }
                        
                        break;
                    //Swap - word1 - word2
                    case "Swap":
                        string firstWord = splittedCommand[1];
                        string secondWord = splittedCommand[2];
                        if(words.Contains(firstWord)&& words.Contains(secondWord))
                        {
                            int firstWordIndex = words.IndexOf(firstWord);
                            int secondWordIndex = words.IndexOf(secondWord);
                            words[firstWordIndex] = secondWord;
                            words[secondWordIndex] = firstWord;

                        }
                        break;
                    //Put - word 1 - index
                    case "Put":
                        string wordToInsert = splittedCommand[1];
                        index = int.Parse(splittedCommand[2])-1;
                        if(index>= 0 && index <= words.Count)
                        {
                            words.Insert(index, wordToInsert);
                        }
                            
                        break;
                    //Sort
                    case "Sort":
                        words = words.OrderByDescending(word => word).ToList();
                        break;
                    //Replace word 1 - word2
                    case "Replace":
                        string wordToReplaceitWith = splittedCommand[1];
                        string wordToReplace = splittedCommand[2];
                        if (words.Contains(wordToReplace))
                        {
                            index = words.IndexOf(wordToReplace);
                            words[index] = wordToReplaceitWith;
                        }
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
      

        
}
