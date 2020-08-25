using System;

namespace arrayreview
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "kate";
            names[1] = "molly";
            names[2] = "nancy";
            names[3] = "gerry"; names[4] = "emmett";
            int[] numbers = new int[4] { 12, 34, 56, 76 };


            Console.WriteLine(names[0]); Console.WriteLine(names[1]); Console.WriteLine(names[2]);
            Console.WriteLine(names[3]); Console.WriteLine(names[4]);
            //Console.WriteLine(numbers[0]); Console.WriteLine(numbers[1]); Console.WriteLine(numbers[2]); 
            //  Console.WriteLine(numbers[3]);
            //this code does the same thing as the for loop below but it takes more time to write 
            for (int index =0; index < 4; index++)
            {
                Console.WriteLine(numbers[index]);
            }
            //add more to this, sort an array!
            //sorting an array
            //the array is declared
            int[] arr = new int[] { 4, 3, 90, 76, 42, 8 };
            // Sort array in ascending order. 
            Array.Sort(arr);

            // reverse array 
            Array.Reverse(arr);

            // print all element of array 
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
