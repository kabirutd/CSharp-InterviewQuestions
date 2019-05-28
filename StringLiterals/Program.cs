using System;

namespace StringLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            StringLiteral1(@"jamais \a with backslah \b with backslah "" With double quote "" ");

        }

        static void StringLiteral1(string input)
        {
            int n= 200;
            var foo = $@"There is the input along with C:\user\mkabir ""kamais"" number var: {input} {n}!";
            Console.WriteLine(foo);
        }

    }
}
