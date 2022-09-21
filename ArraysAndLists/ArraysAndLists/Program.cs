using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Arrays and Lists");
            //// declaring an Array
            //int[] numArray0;
            //// instanciating an array (creating a new object of it)
            //int[] numArray = new int[5]; // of length 5
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //// we can instanciate this way as well
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //// an easier method to initialize an array
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 23000 };

            //Console.WriteLine(numArray[3]);
            //Console.WriteLine(numArray1[3]);
            //Console.WriteLine(numArray2[3]);

            // Lists are more common to use (created from c#2.0)
            // we will use using System.Collections.Generic;
            List<int> intList = new List<int>();

            // to add to the list
            intList.Add(4);
            intList.Add(10);
            Console.WriteLine(intList[1]);

            // to remove an item from the list
            intList.Remove(10);
            Console.WriteLine(intList[0]);


            Console.ReadLine();
            
        }
    }
}
