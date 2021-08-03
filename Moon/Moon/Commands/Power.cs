using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Moon.Commands
{
    public class Power : Command
    {

        public Power(String name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            switch (args[0])
            {
                case "shutdown":
                    Console.WriteLine("Shutting Down...");
                    Sys.Power.Shutdown();
                    break;
                case "reboot":
                    Console.WriteLine("Restarting...");
                    Sys.Power.Reboot();
                    break;
                case "restart":
                    Console.WriteLine("Restarting...");
                    Sys.Power.Reboot();
                    break;
                case "test":
                    break;
            }
            return "";
        }

    }
}
