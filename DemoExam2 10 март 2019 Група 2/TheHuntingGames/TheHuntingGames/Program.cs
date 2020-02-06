using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double waterForAll = daysOfAdventure * countOfPlayers * water;
            double foodForAll = daysOfAdventure * countOfPlayers * food;
            double energyLoss;

            bool isBreaked = false;
            for (int i = 1; i <= daysOfAdventure; i++)
            {
                energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    isBreaked = true;
                    break;
                }
                //every second day they drink water and gain 5% energy and loose 30% water supply
                 if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    waterForAll -= waterForAll * 0.3;
                } 
                if (i % 3 == 0 )
                {
                    groupEnergy += groupEnergy * 0.1;
                    foodForAll -= foodForAll / countOfPlayers;
                }
            }
            if (isBreaked == false)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else if (isBreaked == true)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodForAll:f2} food and {waterForAll:f2} water.");
            }
                

        }
    }
}
