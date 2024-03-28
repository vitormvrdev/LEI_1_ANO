using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;

namespace TernaryOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string tempMessage;
            Console.WriteLine("Introduza uma temperatura");
            string temperatura = Console.ReadLine();

            bool validInteger = int.TryParse(temperatura, out int val);

            if (validInteger)
            {
               tempMessage = val <= 15 ? "Its too cold outside" : (val >= 16 && val < 28) ? "Its ok" : "its hot as shit";
            }else
            {
                Console.WriteLine("Temperatura inválida");
                return;
            }

            Console.WriteLine(tempMessage);
        }
    }
}
