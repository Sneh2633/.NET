using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class FileEx
    {
        static string path = "E:\\.NET LTI\\FileHandlingDemos\\file1.txt";
        static void Main(string[] args)
        {

            Console.WriteLine("Creating File " + path);

            if (!File.Exists(path))
            {
                // Console.WriteLine("File didn't exist;creating new one now");
                File.Create(path);
            }
           write3Lines(path);
            ReadWholeFile();
        }
        public static void write3Lines(string path)
        {
           
             Console.WriteLine("Enter 3 lines of text to write to the file:");
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            try
            {
                TextWriter writer = new StreamWriter(path);
                writer.WriteLine(input);
                writer.WriteLine(input2);
                writer.WriteLine(input3);
                writer.Close();
            }
            catch (IOException i)
            {
                Console.WriteLine("Error: " + i.Message);
            }
            Console.WriteLine();
            Console.WriteLine("The contents of your file are:");

            try
            {
                TextReader reader = new StreamReader(path);
                string line = reader.ReadLine();
                Console.WriteLine("Last line in file is \"" + line + "\"");
                reader.Close();
            }
            catch (IOException i)
            {
                Console.WriteLine("Error: " + i.Message);
            }
        }
        public static void ReadWholeFile()
        {
            try
            {
                TextReader reader = new StreamReader(path);
                List<string> lines = new List<string>();
                string buffer = "";

                while ((buffer = reader.ReadLine()) != null)
                {
                    lines.Add(buffer);
                }

                Console.WriteLine();
                Console.WriteLine("tHE CONTENTS OF YOUR FILE ARE: ");

                foreach (string str in lines)
                {
                    Console.WriteLine(str);
                }
            }
            catch (IOException i)
            {
                Console.WriteLine("Error: " + i.Message);
            }
        }
    
    }
}
