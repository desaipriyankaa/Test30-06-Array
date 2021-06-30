using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayPractice1
{
    class Print
    {
        public int[] UserInput()
        {
            Console.WriteLine("Input 5 numbers :");
            int[] array = new int[5];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =Convert.ToInt32( Console.ReadLine());
            }
            return array;
        }
        public void PrintArray(int[] array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }
    }
}
