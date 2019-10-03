using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of string type 
            GFG<string> name = new GFG<string>();
            name.value = "Mohammad Kabir";

            // instance of float type 
            GFG<float> version = new GFG<float>();
            version.value = 5.0F;

            // display Mohammad Kabir 
            Console.WriteLine(name.value);

            // display 5 
            Console.WriteLine(version.value);

            // creating object of class GFGMethod 
            //=============================================================================
            GFGMethod p = new GFGMethod();

            // calling Generics method 
            p.Display<int>("Integer", 122);
            p.Display<char>("Character", 'H');
            p.Display<double>("Decimal", 255.67);
            //return 0;
        }
    }

    public class GFGMethod
    {
        // Generics method 
        public void Display<GenericType>(string msg, GenericType value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }



    // We use < > to specify Parameter type 
    public class GFG<T>
    {

        // private data members 
        private T data;

        // using properties 
        public T value
        {

            // using accessors 
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
}
