using System;

namespace Nullable
{
    /*
     
        https://www.c-sharpcorner.com/uploadfile/prasoonk/getting-started-with-nullable-types-in-C-Sharp/
     
    */
    class Program
    {
        static void Main(string[] args)
        {
            //AssignNullableToNonNullableUsingCoalescingOperator();
            //AssignNullableToNonNullableUsingCoalescingOperator2();
            //NullCoalescingOperator();
            NullCoalescingOperator2();
        }


        static void AssignNullableToNonNullable()
        {
            //Directly assigning Nullable Type Variable Value to a not Nullable Type Variable is illegal.
            int? x = 4;
            //int y = x; //Error 1 Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)
            int y = 5;
            Console.WriteLine(y.ToString());
            Console.ReadLine();
        }

        static void AssignNullableToNonNullableUsingCoalescingOperator()
        {
            //Directly assigning Nullable Type Variable Value to a not Nullable Type Variable is illegal.
            int? x = 4;
            int y = x ?? 0; //Error 1 Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)
            Console.WriteLine($" int? x = 4   int y = x ?? 0  so y={y.ToString()}");
            Console.ReadLine();
        }

     

        static void NullCoalescingOperator()
        {
            int? x = null;
            int y = 4;
            int? result;

            result = x ?? y; //assign the value of "x" to" result " if "x" is not null else it will assign the value of "y" to "result".
            Console.WriteLine($"x={x} and y={y} and result={result.ToString()}" );
            Console.ReadLine();

        }

        static void NullCoalescingOperator2()
        {
            int? x = 5;
            int y = 4;
            int? result;

            result = x ?? y; //assign the value of "x" to" result " if "x" is not null else it will assign the value of "y" to "result".
            Console.WriteLine($"x={x} and y={y} and result={result.ToString()}");
            Console.ReadLine();

        }
    }
}
