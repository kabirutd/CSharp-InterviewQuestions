using System;

namespace VarVsDynamic
{
    class Program
    {
        /*
        
            https://www.c-sharpcorner.com/blogs/difference-between-var-and-dynamic-in-c-sharp2
         */
        static void Main(string[] args)
        {

            var x = "string 1";
            int l = x.Length;
            //x = 12; //will throw error is x is var and of type string

            dynamic y = "String 2";
            int l2 = y.Length;

            y = 12; //will not throw error is y is a dynamic var



        }
    }
}
