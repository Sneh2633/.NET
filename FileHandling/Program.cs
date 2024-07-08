using System.IO;
/*
 * File-> partial static class.
 * FileInfo -> sealed class.
 * DirectoryInfo -> 
 * @ ->sign used to remove special meaning of \ in the path.
 */
namespace FileHandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string path = @"E:\.NET LTI\csharp.txt";

            Console.WriteLine("Creating file: "+path);
            if (!File.Exists(path))
            {
                Console.WriteLine("File didn't exist;creating one now");
                File.Create(path);
            }

            Console.WriteLine("Enter a line of text to write into the file: ");
            string input=Console.ReadLine();


        }
    }
}
