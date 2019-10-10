using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 2, 7, 9 };

            int[] res = reverseArray(arr);

            Console.WriteLine(string.Join(" ", res));
        }

        static int[] reverseArray(int[] a)
        {
            int[] intArray = a;
            Array.Reverse(intArray);
            return intArray;
        }
    }
}
