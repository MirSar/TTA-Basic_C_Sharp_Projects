using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// asking for name
            //Console.WriteLine("What is your name? ");
            //string yourName = Console.ReadLine();
            //// using user input
            //Console.WriteLine("Greetings " + yourName + ". How may I be of service?");
            //// keep console open
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //// Convert datatype from string to int
            //int fNum1 = Convert.ToInt32(favoriteNumber);
            //// math operation
            //int fNum = 114 + fNum1;
            //// output
            //Console.WriteLine("Your favorite number plus 114 is " + fNum);
            //Console.ReadLine();

            //// byte takes integers from 0 to 255
            //byte hoursworked = 42;
            //bool isStudying = true;
            //// character is one unicode character (+65 thoursnd)
            //char questionMark = '\u2103';
            //// signed byte -128 to 127
            //sbyte currenttemp = -23;
            //short temperatureonmars = -341;
            //float secondsleft = 2.624567f;
            //// int whole numbers +-2billion
            //int starsingallaxies = 200000000;
            //uint biggallaxies = 400000000;
            //// float with 14-15 digits
            //double heightincentimeters = 21.4654;
            //long bignum = 123456789112345678;
            //// largest datatype decimal (28-29 digits in length)
            //// for decimal use suffix 'm'
            //decimal moneyinbank = 100.5m;
            //// output
            //Console.WriteLine(questionMark);
            //Console.WriteLine(isStudying);
            //Console.WriteLine(hoursworked);
            //Console.WriteLine(currenttemp);
            //Console.WriteLine(temperatureonmars);
            //Console.WriteLine(secondsleft);
            //Console.WriteLine(starsingallaxies);
            //Console.WriteLine(biggallaxies);
            //Console.WriteLine(heightincentimeters);
            //Console.WriteLine(bignum);
            //Console.WriteLine(moneyinbank);
            //Console.ReadLine();

            // Casting = converting one datatype to another
            // It is best to avoid the need to cast
            int currentAge = 45;
            string yearsOld = currentAge.ToString();
            Console.WriteLine("You are " + yearsOld + " years young");
            Console.ReadLine();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine("raining? " + rainingStatus);
            Console.ReadLine();


        }
    }
}
