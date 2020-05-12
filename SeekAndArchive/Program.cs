using System;
using System.IO;
using System.Linq;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(args[1]);
            String fileToFind = args[0];

            Console.WriteLine("This is the thing to be printed " + di.GetFiles(fileToFind)[0]);
        }
    }
}