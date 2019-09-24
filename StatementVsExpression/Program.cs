using System;

namespace StatementVsExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer number: ");

            var inputNumber = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("Result using Expression: " + Expression(inputNumber));
            Console.WriteLine("Result using Statement: " + Statement(inputNumber));
        }

        static string Statement(int num1)
        {
            string posOrNegMsg="";

            if (num1>0)
            {
                posOrNegMsg = $"{num1} is positive.";
            }
            else
            {
                posOrNegMsg = $"{num1} is negative.";
            }

            return posOrNegMsg;
        }

        static string Expression(int num1)
        {
            return ($"{num1} is {(num1>0 ? "positive" : "negative")}");
        }
    }
}
