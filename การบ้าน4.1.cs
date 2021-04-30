using System;

namespace _01_การบ้าน4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, b, c, d;
            int a = 1;
            Console.Write("Insert row : ");
            rows = int.Parse(Console.ReadLine());

            if (rows >= 0)
            {
                for (c = 0; c < rows; c++)
                {

                    for (d = 0; d <= c; d++)
                    {
                        if (d == 0 || c == 0)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = a * (c - d + 1) / d;
                            Console.Write(a + " ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal's Triangle row number");
            }
            Console.ReadLine();
        }
    }
}
