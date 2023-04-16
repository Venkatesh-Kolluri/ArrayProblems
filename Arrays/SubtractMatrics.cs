using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SubtractMatrics
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Matric: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[size, size];
            int[,] arr2 = new int[size, size];
            int[,] result = new int[size, size];


            Console.Write("Enter elements in matrix arr1 of size {0}x{0}: \n", size);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("Enter arr1[{0},{1}]:", row, col);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.Write("Enter elements in matrix arr2 of size {0}x{0}: \n", size);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("Enter arr2[{0},{1}]:", row, col);
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());


                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {

                    result[row, col] = arr1[row, col] - arr2[row, col];
                }
            }
            Console.WriteLine("Subtraction of Matrics arr1 - arr2= ");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {

                    Console.Write("{0} ", result[row, col]);
                }
                Console.WriteLine(" ");
            }



        }
    }
}
