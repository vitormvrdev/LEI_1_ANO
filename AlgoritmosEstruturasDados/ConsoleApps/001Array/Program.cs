using System.ComponentModel.Design;

namespace LearnCsharp
{
    internal class Program
    {
        static int[] notas = new int[5]; // Array para guardar as notas
        static void Main(string[] args)
        {
            Menu(); // Chama a função MENU que funciona como base do programa
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("MENU - GESTÃO DE NOTAS");
                Console.WriteLine("1 - Introdução de dados");    //Apresenta-se as opcoes do menu
                Console.WriteLine("2 - Mostrar dados");
                Console.WriteLine("3 - Nota maior");
                Console.WriteLine("4 - Nota menor");
                Console.WriteLine("5 - Nº de positivas e negativas");
                Console.WriteLine("0 - Sair");

                // É pedido ao Utilizador que introduza o número da funcionalidade aprensentada no Menu
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        IntroduzirDados();
                        break;
                    case 2:
                        MostrarDados();
                        break;
                    case 3:
                        MaiorNota();
                        break;
                    case 4:
                        MenorNota();
                        break;
                    case 5:
                        NumeroPositivasENegativas();
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

        /*Função que trata da introdução dos dados*/
        static void IntroduzirDados()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                bool notaValida = false;

                while (!notaValida)
                {
                    Console.Write($"Introduza o valor da {i + 1}ª Nota: ");
                    int nota = Convert.ToInt32(Console.ReadLine());

                    if (IsValid(nota))
                    {
                        notas[i] = nota;
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

        static void MostrarDados()
        {
            for (int k = 0; k < notas.Length; k++)
            {
                Console.WriteLine($"{k + 1}ª nota: {notas[k]}");
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

        static void MaiorNota()
        {
            int maiorNota = notas[0];
            for (int k = 0; k < notas.Length; k++)
            {
                if (notas[k] > maiorNota)
                {
                    maiorNota = notas[k];
                }
            }
            Console.WriteLine($"A maior nota é: {maiorNota}");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void MenorNota()
        {
            int menorNota = notas[0];
            for (int l = 0; l < notas.Length; l++)
            {
                if (notas[l] < menorNota)
                {
                    menorNota = notas[l];
                }
            }
            Console.WriteLine($"A menor nota é: {menorNota}");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void NumeroPositivasENegativas()
        {
            int somaNegativas = 0;
            int somaPositivas = 0;
            for (int h = 0; h < notas.Length; h++)
            {
                if (notas[h] < 10)
                {
                    somaNegativas += 1;
                }

                if (notas[h] >= 10)
                {
                    somaPositivas += 1;
                }
            }
            Console.WriteLine($"O número de contas positivas é: {somaPositivas}.\nO número de notas negativas é: {somaNegativas}.");
            Console.WriteLine("ENTER p/continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}