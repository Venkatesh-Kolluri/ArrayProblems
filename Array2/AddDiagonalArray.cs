using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class AddDiagonalArray
    {
        public static void Main(string[] args)
        {
            int[,] num = {
                {5,45,5,9,8},
                {2,3,6,4,7},
                {8,9,4,75,32},
                {10,20,30,40,50},
                {9,8,7,4,5 } };

            //Getting Row and Column Length
            int rowlength = num.GetLength(0);
            int columnlength = num.GetLength(1);
            int sum = 0;
            Console.Write("Diagonals are : ");
            for (int row = 0; row < rowlength; row++)
            {
                for (int col = 0; col < columnlength; col++)
                {
                    if (row == col)
                    {
                        Console.Write(num[row, col] + " ");
                        sum += num[row, col];
                    }
                }
            }
            Console.WriteLine(" Sum = " + sum);
        }
    }
}
