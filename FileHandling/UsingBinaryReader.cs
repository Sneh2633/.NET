using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class UsingBinaryReader
    {
        static void Main4(string[] args)
        {
            string path = "E:\\.NET LTI\\file2.txt";

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Book");
            bw.Write(28);
            bw.Write(23.89);

            bw.Close();
            fs.Close();


            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine($"Name : {br.ReadString()} \n" +
                $" Number : {br.ReadInt32()} \n Price : {br.ReadDouble()}");


            Console.ReadLine();
        }
    }
}
