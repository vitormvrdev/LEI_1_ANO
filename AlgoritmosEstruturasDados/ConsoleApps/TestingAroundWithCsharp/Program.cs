namespace TestingAroundWithCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Add(num1, num2));
            Console.ReadKey();
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
