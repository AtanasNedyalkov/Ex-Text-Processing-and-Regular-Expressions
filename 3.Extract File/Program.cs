using System;

namespace _3.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int startIndexOfFile = path.LastIndexOf('\\') + 1;
            string file = path.Substring(startIndexOfFile);
            int startIndexOfExtention = file.LastIndexOf('.');
            string nameOfFile = file.Substring(0, startIndexOfExtention - 1);
            string extentionFile = file.Substring(startIndexOfExtention);
            Console.WriteLine(nameOfFile);
            Console.WriteLine(extentionFile);
        }
    }
}
