using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 20, 5, 30, 42, 100 };

            Console.WriteLine("Sorting in ascending order");

            Array.Sort(intArray);

            
            foreach (int i in intArray)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("Sorting in descending order");


            Array.Reverse(intArray);


            foreach (int i in intArray)
            {

                Console.WriteLine(i);
            }


        }
    }
}
