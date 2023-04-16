using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class DeleteArrayElement
    {

        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements into An Array: ");
            int[] num = new int[size];
            int[] arr = new int[num.Length - 1];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int index;
            Console.WriteLine("Enter the Index Number to be deleted: ");
            index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {

                    for (i = index; i < arr.Length; i++)
                    {
                        arr[i] = num[i + 1];
                    }


                }
                else
                {
                    arr[i] = num[i];
                }

            }
            Console.Write("Array Element after Delete: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }

        }

    }
}
