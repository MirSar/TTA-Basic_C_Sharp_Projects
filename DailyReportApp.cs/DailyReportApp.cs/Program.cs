using System;

namespace DailyReportApp.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("======================================");
            Console.WriteLine("Please answer the following questions:");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string ipageNum = Console.ReadLine();
            ushort pageNum = Convert.ToUInt16(ipageNum);

            Console.WriteLine("Do you need help with anything? \nPlease answer \"true\" or \"false\" ");
            string ineedHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(ineedHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? \n Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? \n Please give specifics.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string ihoursStudied = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(ihoursStudied);

            Console.WriteLine("*********************************");
            Console.WriteLine("Thank you for your answers.\n" +
                "An Instructor will respond to this shortly.\n" +
                "Have a great day!");
            Console.WriteLine("*********************************");

            // Testing user input via output
            Console.WriteLine("Checking Output:");
            Console.WriteLine(yourName);
            Console.WriteLine(currentCourse);
            Console.WriteLine(pageNum);
            Console.WriteLine(needHelp);
            Console.WriteLine(posExperience);
            Console.WriteLine(feedback);
            Console.WriteLine(hoursStudied);

            // keep the Console open
            Console.ReadLine();

        }
    }
}
