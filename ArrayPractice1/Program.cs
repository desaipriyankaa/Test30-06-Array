using System;

namespace ArrayPractice1
{
    // Program to take 5 values from the user and store them in an array
    // Print the elements stored in the array

    class Program
    {
        static void Main(string[] args)
        {
            Print printarr = new Print();
            //int[] arr = { 5, 99, 65, 8, 10 };
            int[] arr = printarr.UserInput();
            printarr.PrintArray(arr);
            Array.Sort(arr);
            printarr.PrintArray(arr);
        }
    }
}
