using System;
using System.Collections.Generic;

namespace SwitchExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = 2;

            var result = operation switch
            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                4 => "Case 4",
                _ => "No case availabe"
            };

            Console.WriteLine(result);

            //==============================more stuffs========================
            Console.WriteLine("C# 8.0 New Feature Swtich Expressions");

            //example1    
            var (a, b, option) = (10, 5, "+");

            var example1 = option switch
            {
                "+" => a + b,
                "-" => a - b,
                _ => a * b
            };
            Console.WriteLine("Example 1 : " + example1);

            //example2    
            var cal = new Calculation(10, 20, "/");
            var example2 = cal.Operation switch
            {
                "+" => cal.FirstNumber + cal.SecondNumber,
                "-" => cal.FirstNumber - cal.SecondNumber,
                _ => cal.FirstNumber * cal.SecondNumber,
            };
            Console.WriteLine("Example 2 : " + example2);
            Console.WriteLine("Property Assignment : " + cal.LogLevel);

            //example3    
            var value = 25;

            int example3 = value switch
            {
                _ when value > 10 => 0,
                _ when value <= 10 => 1
            };
            Console.WriteLine("Example 3 : " + example3);

            //example4    
            var dic = new Dictionary<string, string>();
            var (key, defaultValue) = ("Jeetendra", "C# Corner");

            var example4 = dic.TryGetValue(key, out string val) switch
            {
                false => defaultValue,
                _ => val
            };
            Console.WriteLine("Example 4 : " + example4);
        }
    }
}
