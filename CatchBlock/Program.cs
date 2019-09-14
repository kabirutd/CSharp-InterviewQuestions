using System;

namespace CatchBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException Details: " + de);
            }
            catch (Exception ee)
            {
                Console.WriteLine("Exception: " + ee);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);
        }

    }
}

