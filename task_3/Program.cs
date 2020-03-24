using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[13];
            Random rnd = new Random(50);
            int max = mas1[0];
            
            Console.WriteLine($"Элементы массива mas1");
            
            for (int i = 0; i < 12; i++)

            {
                mas1[i] = rnd.Next(13);
                Console.WriteLine($" {mas1[i]} ");
                
                if (mas1[i] > max)
                {
                    max = mas1[i];

                }
            }
            Console.WriteLine($"Максимальный элемент массива {max}");

        }
    }
}
