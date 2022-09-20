using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching examples:");
            Console.WriteLine("");
            //int currentTemp = 77;
            //int roomTemp = 77;
            //// Ternary Operator
            //string comparisonResult = currentTemp == roomTemp ? "current temp is at room temp" : "current temp is not at room temp";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //int roomTemperature = 69;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature of where you are at?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //// comparison operator
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is room temp.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is cooler than room temp");
            //}

            //Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result = favNum == 12 ? "It is 12!" : "not 12";
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
