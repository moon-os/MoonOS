using System;
using System.Collections.Generic;
using System.Text;

namespace Moon.Commands
{
    public class Command
    {
        public readonly String name;

        public Command(String name)
        {
            this.name = name;
        }

        public virtual String execute(String[] args)
        {
            return "";
        }
    }
}
