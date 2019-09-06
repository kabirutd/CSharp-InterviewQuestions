using System;
using System.Collections.Generic;

namespace CountDupsInArray
{
    class Program
    {
        static void Main(string[] args)
        {


            CountDups2();
            //CountDups3();
            //int copt = 1;
            //int element = 0;
            //int[] array = { 1, 4, 3, 3, 3, 5, 2, 3, 7, 3, 3, 4, 5 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length - 1; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            element = array[i];
            //            copt++;
            //            //break;
            //        }
            //    }
            //}

            //Console.WriteLine("the repeat element is {0} and it's appears {1} times ", element, copt);
            //Console.ReadKey();
        }

        static void CountDups2()
        {
            var counts = new Dictionary<int, int>();
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 12, 5, 6, 7, 8, 9, 11, 12, 12 };
            
            for (int i = 0; i < array.Length; i++)
            {
                int currentVal = array[i];
                if (counts.ContainsKey(currentVal))
                    counts[currentVal]++;
                else
                    counts[currentVal] = 1;
            }
            foreach (var kvp in counts)
                Console.WriteLine("\t\n " + kvp.Key + " occurs " + kvp.Value);
        }

        static void CountDups3()
        {
            
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int[] uniqueArray;
            int[] count = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                count[i] = 1;
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        count[i]++;
                       
                    }
                }

                Console.WriteLine("\n " + array[i] + " occurs " + count[i].ToString() + " times.");

                if (count[i] > 1) continue;

                
            }
        }
    }
    
}
