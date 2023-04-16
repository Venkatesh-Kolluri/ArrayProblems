using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MaxMinArray
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elments into an array: ");
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = num[0];
            int min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                int temp = num[i];

                if (temp <= min)
                {
                    min = temp;
                }
                else if (temp > max)
                {
                    max = temp;

                }

            }
            Console.WriteLine("Maxinum number in Array: " + max);
            Console.WriteLine("Minium number in Array: " + min);

        }
    }
}
