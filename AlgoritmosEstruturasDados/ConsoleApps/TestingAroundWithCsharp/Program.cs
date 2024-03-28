using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;

namespace TestingAroundWithCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduza uma temperatura");
            int temperatura = Convert.ToInt16(Console.ReadLine());
            string resultado;
            if (temperatura <= 0 || temperatura >= 0)
            {
                resultado = temperatura <= 15 ? "Its too cold outside" : (temperatura >= 16 && temperatura < 28) ? "Its ok" : "its hot as shit";
            }else
            {
                Console.WriteLine("Temperatura inválida");
            }

            Console.WriteLine(resultado);
        }
    }
}
