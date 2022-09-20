using System;

namespace CarInsuranceApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("This is a basic approval program for car insurance.\n" +
                "Based on your answers the app will determine\n" +
                "if you qualify for car insurance.");
            Console.WriteLine("****************************************************");
            Console.WriteLine("Please answer the following questions:");
            
            Console.WriteLine("What is your age?");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);
            
            Console.WriteLine("Have you ever had a DUI? (true or false)");
            string inputHadDUI = Console.ReadLine();
            bool hadDUI = Convert.ToBoolean(inputHadDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string inputSpeedTick = Console.ReadLine();
            int speedTick = Convert.ToInt32(inputSpeedTick);

            // determine if the applicant is qualified
            bool oldEnough = age > 15;
            bool lessThan3Tick = speedTick <= 3;

            // Printing the results
            Console.WriteLine("Qualified?");
            Console.WriteLine(oldEnough && lessThan3Tick && hadDUI==false);

            // keeps the console open
            Console.ReadLine();
        }
    }
}
