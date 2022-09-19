using System;

namespace NumCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Please Enter your favorite number:");
            string ifavNum = Console.ReadLine();
            Console.WriteLine("***********************************");
            Console.WriteLine("Here is some calculated numbers in regards to your favorite number:");

            decimal FavNum = Convert.ToDecimal(ifavNum);
            Console.WriteLine("favNum * 50 = " + (FavNum * 50));
            Console.WriteLine("favNum + 25 = " + (FavNum + 25));
            // can't perform "/" for decimal or double... using long
            Console.WriteLine("favNum / 12.5 = " + ((long)FavNum / 12.5));
            Console.WriteLine("is favNum > 50? " + (FavNum>50));
            Console.WriteLine("remainder of favNum / 7 = " + (FavNum % 7));

            // keep the console open
            Console.ReadLine();
        }
    }
}
