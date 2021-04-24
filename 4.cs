using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1, y1, x2, y2;
            Console.WriteLine("in put your x1 :");
            Console.WriteLine("in put your x2 :");
            Console.WriteLine("in put your y1 :");
            Console.WriteLine("in put your y2 :");
            x1 = float.Parse(Console.ReadLine());
            y1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;

                }
                Console.WriteLine();

            }
            else
            {
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;

                }
                Console.WriteLine();

            }
        }
    }
}

