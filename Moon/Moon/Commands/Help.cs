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
            return "------ Moon Help ------\nhelp";
        }

    }
}
