using System.Reflection.Metadata.Ecma335;

namespace Exponencial
{
    internal class Program
    {
        static int fPotencia_n(int x, int y)
        {
            int r = 1;
            for (int i = 1; i <= y; i++)
            {
                r *= x;
            }
            return r;
        }

        static int fPotencia_r(int x, int y)
        {
            return y == 0 ?  1 : (x * fPotencia_r(x, y - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 2;
            int y = 3;
            Console.WriteLine($"fPotencia_n({x}, {y}) = {fPotencia_n(x, y)}");
            Console.WriteLine($"fPotencia_r({x}, {y}) = {fPotencia_r(x, y)}");
        }
    }
}
