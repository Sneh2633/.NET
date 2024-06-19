using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# characters.
            char c='a';
            char d='1';
            char s='*';

            int i=sizeof(char);//2 
            Console.WriteLine(i);

            //c# Strings.
        string s1="Hello"; //string literals
        string s2="Snehal!";
        string s3="****";

        Console.WriteLine(s1+s2);
        Console.WriteLine(s2);
        Console.WriteLine(s3);

        //verbatim- symbols are used for particular meaning like escape sequence.
        String s4=@"E:\.NET LTI\CMS.application";
        Console.WriteLine(s4);

        //interpolated string

        string str=$"hello {s2}";
        System.Console.WriteLine(str);
        }
    }
}