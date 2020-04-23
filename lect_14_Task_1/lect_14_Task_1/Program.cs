using System;

namespace lect_14_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, guys";
            string text1 = text.StringAdd();
            Console.WriteLine(text1);

            Console.Read();
        }
    }

    public static class StringExt
    {
        public static string StringAdd(this string str)
        {

            str = str.Substring(5);
            str = str.Insert(6, "...");

        }
    }
}
