using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            I1 c1 = new Class1();
            I2 c2 = new Class1();
            c1.Method1();
            c2.Method1();

            //Following won't work since both Interface has a common method called Method1.
            // We will have to use explicit interface calling

            /*
            Class1 c3 = new Class1();
            Class1 c4 = new Class1();
            c3.Method1();
            c4.Method1();
            */
        }
    }

    public interface I1
    {
         void Method1();
         void Method2();
    }

    public interface I2
    {
         void Method1();
    }

    public class Class1: I1, I2
    {
        void I1.Method1()
        {
            Console.WriteLine("This is Method1 called from I1 ");
        }

        void I2.Method1()
        {
            Console.WriteLine("This is Method1 called from I2");
        }

        public void Method2()
        {

        }
    }
}
