using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Moon
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Moon v0.3.0");
        }

        protected override void Run()
        {

        }
    }
}
