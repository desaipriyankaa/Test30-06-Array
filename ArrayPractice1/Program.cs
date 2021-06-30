using System;

namespace ArrayPractice1
{
    // Program to take 5 values from the user and store them in an array
    // Print the elements stored in the array

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 6, 8, 10 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
