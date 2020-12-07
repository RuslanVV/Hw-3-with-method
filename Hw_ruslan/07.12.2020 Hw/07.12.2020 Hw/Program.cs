using System;

namespace _07._12._2020_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculate metodu - parameter olaraq int array ve 
        bir operator qebul eden metod yazirsiniz.Gonderilmis eddler uzerinde operator uygun hesablama emeliyati aparilmalidir.
        Bu metodun eyni ile double ve decimal arraylerle isleyen versiyalarini da yazin
        (overloading tetbiq edin).ps: ededler ve operator console-dan daxil edilsin*/


            
            /*ededler ve operator console-dan daxil edilmesini yazdigim methodda ede bilmirem muellim.
            Bildiyim qederini yazdim geri qalanini tam sekilde basa dusmediyim ucun yaza bilmedim.*/
            Console.WriteLine("X ededini daxil edin:");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y ededini daxil edin:");
            Convert.ToInt32(Console.ReadLine());

            int caltulatingOperator = CalculationMethod(5, '*', 2);
            Convert.ToInt32(Console.ReadLine());

            double calculatorOperator = CalculationMethod(4.4, '+', 2.3);
            Convert.ToInt32(Console.ReadLine());

        }   
        static int CalculationMethod(int x, int calcOperator, int y)

        {
            int result = 0;

            switch (calcOperator)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;

            
            }return result;

          
        }
        static double CalculationMethod(double x, double calcOperator, double y)
        {

            double result = 0;

            switch (calcOperator)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;


            }
            return result;

        }
    }
}


