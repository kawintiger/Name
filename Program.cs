using System;

namespace สอบworkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,X,Y;
            Console.WriteLine("Input Number A");
            Console.WriteLine("Input Number B");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A;
            Y = B;

            while(X!=Y)
            {
                if(X<Y)
                {
                    X = X + A;
                }
                else
                {
                    Y = Y + B;
                }
                Console.Write(X);
            } 
            Console.ReadLine();
        }
    }
}
