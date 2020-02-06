using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] splitCommand = command.Split(' ');
                switch (splitCommand[0])
                {
                    case "Change":
                        int paintingNumber = int.Parse(splitCommand[1]);
                        int changeNumber = int.Parse(splitCommand[2]);
                        if (!numbers.Contains(paintingNumber)) { break; }

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNumber = numbers[i];
                            if (currentNumber == paintingNumber)
                            {
                                numbers.Remove(currentNumber);
                                numbers.Insert(i, changeNumber);
                            }

                        }
                        break;
                    case "Hide":
                        int numberToHide= int.Parse(splitCommand[1]);
                        if (!numbers.Contains(numberToHide))
                        {
                            break;
                        }
                        else
                        {
                            numbers.Remove(numberToHide);
                        }
                        break;
                    case "Switch":
                        int firstPainting = int.Parse(splitCommand[1]);
                        int firstPaintingIndex = numbers.IndexOf(firstPainting);
                        int secondPainting = int.Parse(splitCommand[2]);
                        int secondPaintingIndex = numbers.IndexOf(secondPainting);

                        if (!numbers.Contains(firstPainting)&& !numbers.Contains(secondPainting))
                        {
                            break; 
                        }
                        else
                        {
                            numbers.Remove(firstPainting);
                            numbers.Remove(secondPainting);

                            numbers.Insert(firstPaintingIndex, secondPainting);
                            numbers.Insert(secondPaintingIndex, firstPainting);
                            
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(splitCommand[1]);
                        int numberToInsert = int.Parse(splitCommand[2]);
                        if(index < numbers.Count)
                        {
                            numbers.Insert(index+1, numberToInsert);
                            
                        }
                        else if(index >= numbers.Count)
                        {
                            numbers.Add(numberToInsert);
                        }
                        
                        break;
                    case "Reverse":
                        numbers.Reverse();
                        break;
                    default:
                        break;
                }
            }
            
                Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
