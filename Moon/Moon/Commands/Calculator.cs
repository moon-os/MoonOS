using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Moon.Commands
{
    public class Calculator : Command
    {

        public Calculator(String name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            int num1 = Convert.ToInt16(args[0]);
            int num2 = Convert.ToInt16(args[2]);

            switch (args[1])
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }

            return "";
        }
    }
}
