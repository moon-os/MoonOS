using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;
using Cosmos.System.Graphics;
using Moon.Commands;

namespace Moon
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        public String Version = "v0.3.5";

        protected override void BeforeRun()
        {
            this.commandManager = new CommandManager();
            Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Moon " + Version + "\n");

            Moon.Filesystem.TempFS.initFilesystem();
        }

        protected override void Run()
        {
            String response;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("moon");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("moon-pc");
            Console.ResetColor();
            Console.Write("> ");

            response = this.commandManager.processInput(Console.ReadLine());
            Console.WriteLine(response);
         }
    }
}
