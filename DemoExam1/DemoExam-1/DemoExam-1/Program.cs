using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                coins += 50;//daily coins
                coins -= 2*partySize; //food
                if (i % 3 == 0)//motivational party
                {
                    coins -= 3*partySize;//for drinking water
                }
                if(i % 5 == 0)//slay a boss monster  
                {
                    coins += 20 * partySize;
                    if(i %3 == 0)//motivational party
                    {
                        coins -= 2 * partySize;
                    }
                }            
            }
            Console.WriteLine($"{partySize} companions recieved {coins/partySize} coins each.");
        }
    }
}
