namespace Array2
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {

            int[] num = { 10, 30, 50, 70, 90, 110 };

            for (int i = num.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(num[i]);
            }
        }
    }
}