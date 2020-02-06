using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine().Split('#').ToArray();//medium = 85#high = 60
            int water = int.Parse(Console.ReadLine());
            double efforts = 0;
            int totalFire = 0;
            List<int> fireValues = new List<int>();
            for (int i = 0; i < fires.Length; i++)
            {
                string[] cellsInfo = fires[i]
                    .Split(' ');
                string type = cellsInfo[0];
                int fireValue = int.Parse(cellsInfo[2]);
                bool isCellValid = IsCellValid(type, fireValue);
                if (isCellValid && water - fireValue >= 0)
                {
                    efforts += fireValue * 0.25;
                    water -= fireValue;
                    totalFire += fireValue;
                    fireValues.Add(fireValue);
                }
                
            }
            Console.WriteLine("Cells:");
            foreach (var cell in fireValues)
            {
                Console.WriteLine(" - {0}", cell);
            }
            Console.WriteLine("Effort: {0:f2}",efforts);
            Console.WriteLine("Total Fire: {0}",totalFire);

        }
        static bool IsCellValid(string type, int fireValue)
        {
            if(type == "High")
            {
                if(fireValue>=81 && fireValue <= 125)
                {
                    return true;
                }
            }
            if (type == "Medium")
            {
                if (fireValue >= 51 && fireValue <= 80)
                {
                    return true;
                }
            }
            if (type == "Low")
            {
                if (fireValue >= 1 && fireValue <= 50)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
