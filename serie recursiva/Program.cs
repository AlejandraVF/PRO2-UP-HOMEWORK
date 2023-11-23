using System;

namespace Programacion
{
    public class Program
    {
        public static void Main(string[] args)
        {

            RecursivoDomino(6);
        }
        static int A = 0;
        static int B = 7;
        public static void RecursivoDomino(int N)
        {

            if (N == 0)
            {
                return;
            }
            else
            {
                RecursivoDomino(N - 1);
                int serieA = A + 1;
                int serieB = B - 1;
                A = serieA;
                B = serieB;
                Console.WriteLine("A : " + serieA);
                Console.WriteLine("B : " + serieB);

            }
        }

    }
}