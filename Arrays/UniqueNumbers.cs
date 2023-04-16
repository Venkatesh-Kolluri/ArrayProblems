using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Arrays
{
    internal class UniqueNumbers
    {

        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements into An Array: ");
            int[] num = new int[size];

            bool unique;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Unique elements in the array are: ");
            for (int i = 0; i < size; i++)
            {
                unique = true;
                for (int j = i + 1; j < size; j++)
                {
                    if (num[i] == num[j])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique == true)
                {
                    Console.Write(" " + num[i]);
                }
            }
        }
    }
}