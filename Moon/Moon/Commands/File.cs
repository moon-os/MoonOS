using System;
using System.Collections.Generic;
using System.Text;
using Moon.Filesystem;

namespace Moon.Commands
{
    public class File : Command
    {
        public File(String name) : base(name)
        {

        }

        public override string execute(string[] args)
        {
            switch (args[0])
            {
                case "list":
                    TempFS.listFilesystem();
                    break;

                case "mkfile":
                    TempFS.createFile(args[1], args[2]);
                    break;
            }

            return "";
        }

    }
}
