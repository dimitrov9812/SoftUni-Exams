using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterGift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split(' ').ToList();
            string command;
            while ((command=Console.ReadLine())!="No Money")
            {
                string[] splittedInput = command.Split(' ');
                switch (splittedInput[0])
                {
                    case "OutOfStock"://replace the item with ="None";
                        string currentGift = splittedInput[1];
                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if (gifts[i] == currentGift)
                            {
                                int itemIndex = gifts.IndexOf(gifts[i]);
                                gifts.Remove(currentGift);
                                gifts.Insert(itemIndex, "None");
                            }
                        }
                          
                        break;
                    case"Required":
                        string giftToReplace = splittedInput[1];
                        int wantedIndex = int.Parse(splittedInput[2]);
                        if (wantedIndex<=gifts.Count-1)
                        {
                            gifts.RemoveAt(wantedIndex);
                            gifts.Insert(wantedIndex, giftToReplace);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "JustInCase":
                        string giftToAdd = splittedInput[1];
                        int lastIndex = gifts.Count - 1;
                        gifts.RemoveAt(lastIndex);
                        gifts.Add(giftToAdd);
                        break;
                }
            }
            foreach (var item in gifts)
            {
                if (!item.Contains("None"))
                {
                    Console.Write(item + " ");
                }

            }
            
        }
    }
}
