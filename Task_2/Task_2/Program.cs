using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            short a1 = 1;
            object obj1 = a1;
            System.SByte a2 = (System.SByte)a1; 

            Console.WriteLine(a2);
        }
    }
}
