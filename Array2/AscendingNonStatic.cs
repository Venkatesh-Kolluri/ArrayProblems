using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class AscendingNonStatic
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements into an array: ");
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            AscendingNonStatic a = new AscendingNonStatic();
            a.ascending(arr);

        }
        public void ascending(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
                Console.Write(" " + arr[i]);
            }

        }
    }
}
