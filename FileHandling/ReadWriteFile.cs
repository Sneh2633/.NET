using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class ReadWriteFile
    {
        static void Main1(string[] args)
        {
            string path = "E:\\.NET LTI\\FileDemo.txt";

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);

            StreamWriter writer=new StreamWriter(fs);
            writer.WriteLine("Hello I am Snehal");
            writer.WriteLine("I am learning File handling topic");

            writer.Close();
            fs.Close();


            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            Console.WriteLine(reader.ReadToEnd());
            Console.ReadLine();

        }
    }
}
