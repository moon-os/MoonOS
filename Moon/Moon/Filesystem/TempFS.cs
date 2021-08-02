using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Moon.Filesystem
{
    public class TempFS
    {
        public static List<String> fs;
        public static Array FilesystemDict; 

        public static void initFilesystem()
        {
            fs = new List<String>(2);
            fs.Add("test1*hi");
            fs.Add("test2*hi");
        }

        public static void createFile(string Path, string Text)
        {
            fs.Add(Path + "*" + Text);
        }

        public static void listFilesystem()
        {
            foreach (string item in fs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
