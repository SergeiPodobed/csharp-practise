using System;
using System.Reflection.Metadata.Ecma335;

namespace lect_14_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, guys";
            string text1 = "...";
            string text2 = text.StringAdd(text1);
            Console.WriteLine(text2);

            Console.Read();
        }
    }

    public static class StringExt
    {
        public static string StringAdd(this string str, string text1)
        {

            str = str.Substring(5).Insert(6, text1);
            return str;
        }
        
    }
}
