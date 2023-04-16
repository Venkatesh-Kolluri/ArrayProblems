using System;

namespace Arrays
{
    internal class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = num.Length-1; i >=0; i--)
            {
               
                Console.WriteLine(num[i]);
            }
          

        }
    }
    // Reverse an array(Solution)
}


/*int[] arr = new int[num.Length];


int j = num.Length - 1;

for (int i = 0; i < num.Length; i++)
{

    arr[i] = num[j];
    j = num.Length - 1 - (i + 1);

    Console.WriteLine(arr[i]);
}*/
