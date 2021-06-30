using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayPractice1
{
    class Print
    {
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
