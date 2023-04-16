using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class NegativeElements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in to an array: ");
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Negative Elements in an array are: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    int value = num[i];
                    Console.WriteLine(" " + value);
                }

            }
        }
    }
}
