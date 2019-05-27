using System;

namespace OutRefs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //BY VALUE
            CallerMethodByVal();

            //BY REF
            CallerMethodByRef();

            // BY OUT
            CallerMethodByOut();

        }
        static void CallerMethodByVal()
        {
            int OutSideVar = 40;

            Console.WriteLine("CallerMethodByVal: Value of OutSideVar before calling Callee: " + OutSideVar);

            //Call SomeMethod pasing by value
            CalleeMethod(OutSideVar);
            Console.WriteLine("CallerMethodByVal: Value of OutSideVar after calling Callee: " + OutSideVar);

            Console.WriteLine();
        }

        static void CallerMethodByRef()
        {
            int OutSideVar = 40;

            Console.WriteLine("CallerMethodByRef: Value of OutSideVar before calling Callee: " + OutSideVar);

            //Call SomeMethod pasing by ref
            CalleeMethod(ref OutSideVar);
            Console.WriteLine("CallerMethodByRef: Value of OutSideVar after calling Callee: " + OutSideVar);
            Console.WriteLine();
        }


        static void CallerMethodByOut()
        {
            int OutSideVar = 40;

            Console.WriteLine("CallerMethodByOut: Value of OutSideVar before calling Callee: " + OutSideVar);

            //Call SomeMethod pasing by out
            CalleeMethodOut(out OutSideVar);
            Console.WriteLine("CallerMethodByOut: Value of OutSideVar after calling Callee: " + OutSideVar);
            Console.WriteLine();
        }

        static void CalleeMethod(int inSideVar)
        {
            inSideVar = inSideVar + 20;
        }

        static void CalleeMethod(ref int inSideVar)
        {
            inSideVar = inSideVar + 20;
        }

        /*
         *
         Couldn't use CalleeMethod(out int inSideVar) as varying parameters by out and ref isn't allowed. fro int to ref int
         is allowed though.
         */
        static void CalleeMethodOut(out int inSideVar)
        {
            //passed out var must be initialized
            inSideVar = 0;
            inSideVar = inSideVar + 20;
        }

        static void SomeMethod(int inSideVar)
        {
            inSideVar = inSideVar + 20;
        }
    }
}
