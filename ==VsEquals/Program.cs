using System;

namespace __VsEquals
{
    /*
     
        Resources:
        https://www.c-sharpcorner.com/UploadFile/3d39b4/difference-between-operator-and-equals-method-in-C-Sharp/

     */
    class Program
    {
        static void Main(string[] args)
        {

            Example1();
            Example2();

            Console.ReadLine();
        }


        static void Example1()
        {
            object o = "string object";

            object o1 = o; // "jamais..";
            
            Console.WriteLine("o==o1: " + (o == o1)); //true
            Console.WriteLine("o equals o1: " + o.Equals(o1)); //true
            Console.WriteLine();


        }
        static void Example2()
        {
            object name = "kabir";

            char[] nameChars = {'k','a','b','i', 'r' };
            object name2 = new string(nameChars);

            Console.WriteLine("== operator result is {0}", name == name2);          //false
            Console.WriteLine("Equals method result is {0}", name2.Equals(name));   //true - content is the same
            Console.WriteLine();


        }
    }
}
