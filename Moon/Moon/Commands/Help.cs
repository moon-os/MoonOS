using System;
using System.Collections.Generic;
using System.Text;

namespace Moon.Commands
{
    public class Help : Command
    {
        public Help(String name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            foreach (string i in args)
            {
                Console.WriteLine(i);
            }
            return "------ Moon Help ------\nhelp\npower\n\tshutdown\n\treboot\n\trestart\ncalc\nclear";
        }

    }
}
