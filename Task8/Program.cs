using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputD = "Введите  число";
            Console.WriteLine(InputD);
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            Console.Write("");
        }
    }
}
