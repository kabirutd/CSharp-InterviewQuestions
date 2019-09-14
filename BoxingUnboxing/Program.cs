using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing - Value type to Ref Type 
            int anum = 123;
            Object obj = anum;
            Console.WriteLine("anum: " + anum);
            Console.WriteLine("obj: " + obj);

            // Unboxing - Ref Type to Value type
            Object obj2 = 567;
            int anum2 = (int)obj2;
            Console.WriteLine("anum2: " + anum2);
            Console.WriteLine("obj2:" + obj2);

        }
    }
}
