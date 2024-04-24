using System.Runtime.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números: ");
            int num = Convert.ToInt16(Console.ReadLine());
            double soma = 0;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Qual é o {i + 1}º número: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                soma += numero;
            }
            double media = soma / num;
            Console.WriteLine($"Média = {media}");
        }
    }
}
