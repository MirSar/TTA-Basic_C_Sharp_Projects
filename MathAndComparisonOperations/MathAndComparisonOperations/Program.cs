using System;

namespace MathAndComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ////adding
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //// casting int to string
            //Console.WriteLine("total + otherTotal = " + combined.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("10 - 5 = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //console.writeline("10*5= " + product.tostring());
            //console.readline();

            //// note the numbers being divided needs to be float else it will round down
            //double quotient = 200 / 3;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //// modulus (remainder)... use case = odd or even
            //double remainder = 13 % 2;
            //console.writeline(remainder);
            //console.readline();

            //// Comparison operators..output bool
            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;
            //bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp == roomTemp;
            bool isWarm = currentTemp != roomTemp;

            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
