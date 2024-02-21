using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace LearnCsharp
{
    internal class Program
    {
        // Array para guardar as notas
        static void Main(string[] args)
        {
            int[] notas = new int[5];
            while (true)
            {
                int opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        IntroduzirDados(ref notas);
                        break;
                    case 2:
                        MostrarDados(notas);
                        break;
                    case 3:
                        MaiorNota(notas);
                        break;
                    case 4:
                        MenorNota(notas);
                        break;
                    case 5:
                        NumeroPositivasENegativas(notas);
                        break;
                    case 6:
                        CalcularMedia(notas);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            }
        }

        static int Menu()
        {
            while (true)
            {
                Console.WriteLine("MENU - GESTÃO DE NOTAS");
                Console.WriteLine("1 - Introdução de dados");    //Apresenta-se as opcoes do menu
                Console.WriteLine("2 - Mostrar dados");
                Console.WriteLine("3 - Nota maior");
                Console.WriteLine("4 - Nota menor");
                Console.WriteLine("5 - Nº de positivas e negativas");
                Console.WriteLine("6-  Média das notas");
                Console.WriteLine("0 - Sair");

                // É pedido ao Utilizador que introduza o número da funcionalidade aprensentada no Menu
                return Convert.ToInt32(Console.ReadLine());
            }
        }

        //Função que trata da introdução dos dados
        static void IntroduzirDados(ref int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                bool notaValida = false;

                while (!notaValida)
                {
                    Console.Write($"Introduza o valor da {i + 1}ª Nota: ");
                    int nota = Convert.ToInt32(Console.ReadLine());

                    if (IsValid(nota))
                    {
                        n[i] = nota;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Por favor, insira um número entre 0 e 20.");
                    }
                }
            }
            Console.Clear();
        }

        static void MostrarDados(int[] n)
        {
            for (int k = 0; k < n.Length; k++)
            {
                Console.WriteLine($"{k + 1}ª nota: {n[k]}");
            }
            Console.WriteLine("ENTER p/continuar...");
            Console.ReadKey();
        }

        static bool IsValid(int num)
        {
            if (num >= 0 && num <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MaiorNota(int[] n)
        {
            int maiorNota = n[0];
            for (int k = 0; k < n.Length; k++)
            {
                if (n[k] > maiorNota)
                {
                    maiorNota = n[k];
                }
            }
            Console.WriteLine($"A maior nota é: {maiorNota}");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void MenorNota(int[] n)
        {
            int menorNota = n[0];
            for (int l = 0; l < n.Length; l++)
            {
                if (n[l] < menorNota)
                {
                    menorNota = n[l];
                }
            }
            Console.WriteLine($"A menor nota é: {menorNota}");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void NumeroPositivasENegativas(int[] n)
        {
            int somaNegativas = 0;
            int somaPositivas = 0;
            for (int h = 0; h < n.Length; h++)
            {
                if (n[h] < 10)
                {
                    somaNegativas += 1;
                }

                if (n[h] >= 10)
                {
                    somaPositivas += 1;
                }
            }
            Console.WriteLine($"O número de contas positivas é: {somaPositivas}.\nO número de notas negativas é: {somaNegativas}.");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static void CalcularMedia(int[] n)
        {
            float soma = 0;
            float media;
            for (int g = 0; g < n.Length; g++)
            {
                soma += n[g];
            }
            media = (soma / n.Length);
            Console.WriteLine($"A média das notas é: {media:N2}");
        }
    }
}