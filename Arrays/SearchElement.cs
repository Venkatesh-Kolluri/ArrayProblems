using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SearchElement
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of an array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements into an Array: ");
            int[] num = new int[size];
            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the value to be seached in an array: ");
            int val = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == val)
                {
                    Console.WriteLine(val + " The value is found in index number: " + i);
                }

            }

        }
    }
}
