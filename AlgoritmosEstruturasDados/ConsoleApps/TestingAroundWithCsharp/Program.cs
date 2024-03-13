namespace TestingAroundWithCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um número");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(LesserNum(num));
        }

        static int LesserNum(int n)
        {
            return n - 1;
        }
    }
}
