using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Moon.Commands;

namespace Moon
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;

        protected override void BeforeRun()
        {
            this.commandManager = new CommandManager();
            Console.WriteLine("Moon v0.3.0");
        }

        protected override void Run()
        {
            String response;
            response = this.commandManager.processInput(Console.ReadLine());
            Console.WriteLine(response);
        }
    }
}
