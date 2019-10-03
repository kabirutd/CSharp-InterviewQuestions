using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchExpression
{
    public class Calculation
    {

        public Calculation(int a, int b, string operation)
        {
            this.FirstNumber = a;
            this.SecondNumber = b;
            this.Operation = operation;
        }

        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public string Operation { get; set; }

        public int LogLevel { get; } = Environment.GetEnvironmentVariable("LOG_LEVEL") switch
        {
            "INFO" => 1,
            "DEBUG" => 2,
            _ => 0
        };
    }
}
