using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class FilesInfo
    {
        static void Main2(string[] args)
        {
            string path = "E:\\.NET LTI\\FileDemo.txt";

            FileInfo f=new FileInfo(path);
            //f.Delete();

            //DirectoryInfo dir = new DirectoryInfo(path+"\\LBJ3.0");

            //dir.Create();

            //Directory.CreateDirectory(path + "newLBJ 3.0");

            if(f.Exists)
            {
                Console.WriteLine("File already existed!!");
                Console.WriteLine(f.CreationTime);
                Console.WriteLine(f.Length);
            }
            else
            {
               f.Create();
                //Console.WriteLine("Creating file");
            }

        }
    }
}
