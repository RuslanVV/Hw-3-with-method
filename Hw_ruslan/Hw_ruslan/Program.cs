using System;

namespace Hw_ruslan
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Verilmis x,y,z ededlerinin en boyuyunu console-a yazdiran metod yazin///


            FindBigOne(11, 22, 33);

            int x, y, z;
            string xStr, yStr, zStr;
            do
            {

                Console.WriteLine(" X ededini daxil edin:");
                xStr = Console.ReadLine();

                Console.WriteLine(" Y ededini daxil edin:");
                yStr = Console.ReadLine();

                Console.WriteLine(" Z ededini daxil edin:");
                zStr = Console.ReadLine();


            } while (!(int.TryParse(xStr, out x) && (int.TryParse(yStr, out y) && (int.TryParse(zStr, out z)))));




        }

        static int FindBigOne(int x, int y, int z)
        {

            int result;

            if (x > y && x > z)
                result = x;

            else if (y > x && y > z)
                result = y;

            else
                result = z;

            return result;



        }
        
        
    }
}
