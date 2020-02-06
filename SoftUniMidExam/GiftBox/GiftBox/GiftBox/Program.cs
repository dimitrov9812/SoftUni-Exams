using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            double sheetsOfPaper = double.Parse(Console.ReadLine());
            double singleSheetCoverArea = double.Parse(Console.ReadLine());
            double boxArea = sizeOfSide * sizeOfSide * 6;
            double areaWeCanCover = 0;
            double percentages = 0;
            for (int i = 1; i <= sheetsOfPaper; i++)
            {
                if (i % 3 == 0)
                {
                    areaWeCanCover += singleSheetCoverArea*0.25;
                }
                else
                {
                    areaWeCanCover += singleSheetCoverArea;
                }
            }
            //areaWeCanCover = 90;
            percentages = (areaWeCanCover / boxArea) * 100;
            Console.WriteLine("You can cover {0:F2}% of the box.",percentages);


        }
    }
}
