namespace Array3
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element into an array: ");
            int[] num = new int[size];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Reverse of an array is:");
            for (int i = num.Length - 1; i >= 0; i--)
            {

                Console.Write(" " + num[i]);
            }

        }
    }
}