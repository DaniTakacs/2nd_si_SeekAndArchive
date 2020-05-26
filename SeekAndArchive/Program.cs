using System;
using System.IO;
using System.Linq;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToFind =args[0];
            string root = args[1];

            string[] subdirectoriesEntries = Directory.GetDirectories(root);

            foreach (var subdierctory in subdirectoriesEntries)
            {
                LoadSubDirs(subdierctory, fileToFind);
            }
        }

        private static void LoadSubDirs(String dir, string filename)
        {

            var matchingFiles = Directory.GetFiles(dir, filename);

            if (matchingFiles.Length > 0)
            {
                foreach (var matchingFile in matchingFiles)
                {
                    Console.WriteLine(matchingFile.ToString());
                }
            }

            string[] subdirectoriesEntries = Directory.GetDirectories(dir);
            foreach (var subdirectory in subdirectoriesEntries)
            {
                LoadSubDirs(subdirectory, filename);
            }
        }
    }
}