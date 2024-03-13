using System.Text;

namespace ArrayDeEstruturas
{   // Autor: Vitor Rocha
    // Array de estruturas de colaboradores

    internal class Program
    {
        static void Main(string[] args)
        {
            // Definição de variáveis
            // Inicia uma nova instancia do Struct sColaborador
            sColaborador[] sColab = new sColaborador[0]; //definição de objeto array de estruturas
            int opcao = 0;

            do
            {

                opcao = Menu();


                switch (opcao)
                {
                    case 1:
                        InserirDadosColaborador(ref sColab);
                        break;
                    case 2:
                        ListarColaboradores(sColab);
                        break;
                    case 3:
                        ConsultarColaborador(sColab);
                        break;
                    case 4:
                        AlterarColaborador(ref sColab);
                        break;
                    case 5:
                        RemoverColaborador(ref sColab);
                        break;
                    case 6:
                        ExtrairDocumentoCSV(sColab);
                        break;
                    case 7:
                        LerDocumentoCSV(ref sColab);
                        break;
                }
            } while (opcao != 0);
        }

        struct sColaborador
        {   // Definição da estrutura Colaborador
            public int codigoColab;
            public string nomeColab, moradaColab, generoColab;
            public int idadeColab;
            public double vencimentoColab;
        }

        static int Menu()
        {
            Console.WriteLine("-----Gestão de Colaboradores-----");
            Console.WriteLine("1 - Inserir Colaboradores");
            Console.WriteLine("2 - Listar Colaboradores");
            Console.WriteLine("3 - Consultar Colaborador");
            Console.WriteLine("4 - Alterar dados de colaborador");
            Console.WriteLine("5 - Remover Colaborador");
            Console.WriteLine("6 - Extrair documento CSV");
            Console.WriteLine("7 - Ler documento a partir de um documento CSV");
            Console.WriteLine("0 - Sair");
            Console.Write("Selecione uma opção: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        static void InserirDadosColaborador(ref sColaborador[] sColab)
        {
            Console.WriteLine("Quantos colaboradores pretende inserir?");
            int numColab = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            int tamanhoAtualArray = sColab.Length;

            int novoTamanhoArray = tamanhoAtualArray + numColab;

            Array.Resize(ref sColab, novoTamanhoArray);

            int j = 1;

            for (int i = tamanhoAtualArray; i < novoTamanhoArray; i++)
            {
                Console.WriteLine($"Colaborador nº{j}");
                bool numValido = false;

                while (!numValido)
                {
                    Console.Write("Inserir o código: ");
                    int num2 = Convert.ToInt16(Console.ReadLine());

                    if (isValid(num2, sColab))
                    {
                        sColab[i].codigoColab = num2;
                        numValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Código já existente");
                    }
                }

                Console.Write("Inserir o nome: ");
                sColab[i].nomeColab = Console.ReadLine();

                Console.Write("Inserir o morada: ");
                sColab[i].moradaColab = Console.ReadLine();

                Console.Write("Inserir o genero: ");
                sColab[i].generoColab = Console.ReadLine();

                Console.Write("Inserir o idade: ");
                sColab[i].idadeColab = Convert.ToInt16(Console.ReadLine());

                Console.Write("Inserir o vencimento: ");
                sColab[i].vencimentoColab = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ENTER p/continuar");
                j++;
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void ListarColaboradores(sColaborador[] sColab)
        {
            int j = 1;
            for (int i = 0; i < sColab.Length; i++)
            {
                Console.WriteLine($"Colaborador {j}: ");
                Console.WriteLine($"Código: {sColab[i].codigoColab}\n" +
                $"Nome: {sColab[i].nomeColab}\n" +
                $"Morada: {sColab[i].moradaColab}\n" +
                $"Género: {sColab[i].generoColab}\n" +
                $"Idade: {sColab[i].idadeColab}\n" +
                $"Vencimento: {sColab[i].vencimentoColab}\n");
                Console.WriteLine(sColab.Length);
                j++;
            }

            Console.WriteLine("ENTER p/continuar");
            Console.ReadLine();

        }

        static bool isValid(int num, sColaborador[] sColab)
        {
            for (int i = 0; i < sColab.Length; i++)
            {
                if (num == sColab[i].codigoColab)
                {
                    return false;
                }
            }
            return true;
        }

        static void AlterarColaborador(ref sColaborador[] sColab)
        {
            // Função para alterar dados de um colaborador em especifico
            Console.Clear();
            Console.WriteLine("-----Alterar dados de Colaborador-----");
            ListarColaboradores(sColab);  // Mostra a lista dos Colaboradores atuais

            int codigoColaborador;
            do
            {
                Console.WriteLine("De qual colaborador pretende alterar os dados?");

                codigoColaborador = Convert.ToInt16(Console.ReadLine());

                if (isValid(codigoColaborador, sColab))
                {
                    Console.WriteLine("Código inválido. Por favor introduza um código válido");
                }
            } while (isValid(codigoColaborador, sColab));

            
            for (int i = 0; i < sColab.Length; i++)
            {
                if (codigoColaborador == sColab[i].codigoColab)
                {
                    Console.WriteLine("Pretende um campo em especifico ou todos?");
                    Console.WriteLine("1 - Um campo em especifico");
                    Console.WriteLine("2 - Todos os campos");

                    int userEscolha1 = Convert.ToInt16(Console.ReadLine());

                    if (userEscolha1 == 1)
                    {
                        Console.WriteLine("----Alteração de dados de Colaborador----");
                        Console.WriteLine("Que campo pretende que seja alterado?");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - Morada");
                        Console.WriteLine("3 - Genero");
                        Console.WriteLine("4 - Idade");
                        Console.WriteLine("5 - Vencimento");

                        int userEscolha2 = Convert.ToInt16(Console.ReadLine());

                        switch (userEscolha2)
                        {
                            case 1:
                                Console.WriteLine("Insira novo nome: ");
                                sColab[i].nomeColab = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Insira nova morada: ");
                                sColab[i].nomeColab = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Insira novo genero: ");
                                sColab[i].nomeColab = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Insira nova idade: ");
                                sColab[i].nomeColab = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Insira novo vencimento: ");
                                sColab[i].vencimentoColab = Convert.ToInt16(Console.ReadLine());
                                break;
                            case 0:
                                break;
                        }
                        break;
                    }
                    else if (userEscolha1 == 2)
                    {
                        Console.WriteLine("----Alteração de dados de Colaborador----");
                        Console.WriteLine("Introduza novos dados\n");
                        Console.Write("Inserir o nome: ");
                        sColab[i].nomeColab = Console.ReadLine();

                        Console.Write("Inserir o morada: ");
                        sColab[i].moradaColab = Console.ReadLine();
                        Console.Write("Inserir o genero: ");
                        sColab[i].generoColab = Console.ReadLine();
                        Console.Write("Inserir o idade: ");
                        sColab[i].idadeColab = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Inserir o vencimento: ");
                        sColab[i].vencimentoColab = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("ENTER p/continuar");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido, 1 ou 2.");
                    }
                }
            }
        }

        static void ConsultarColaborador(sColaborador[] sColab)
        {
            Console.WriteLine("------Consultar dados de colaborador------");
            Console.WriteLine("Qual o código de Colaborador que pretende consultar: ");

            Console.Write("Inserir o código: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (!isValid(num2, sColab))
            {
                for (int i = 0;i < sColab.Length; i++)
                {
                    if (num2 == sColab[i].codigoColab)
                    {
                        Console.WriteLine($"Código: {sColab[i].codigoColab}\n" +
                        $"Nome: {sColab[i].nomeColab}\n" +
                        $"Morada: {sColab[i].moradaColab}\n" +
                        $"Género: {sColab[i].generoColab}\n" +
                        $"Idade: {sColab[i].idadeColab}\n" +
                        $"Vencimento: {sColab[i].vencimentoColab}\n");
                        break;
                    }
                }
            }
        }
        
        static void RemoverColaborador(ref sColaborador[] sColab)
        {
            ListarColaboradores(sColab);

            Console.WriteLine("Que utilizador pretende remover?");
            int num = Convert.ToUInt16(Console.ReadLine());

            if (!isValid(num, sColab))
            {
                for (int i = 0; i < sColab.Length; i++)
                {
                    if (num == sColab[i].codigoColab)
                    {
                        for (int j = i; j < sColab.Length - 1; j++)
                        {
                            sColab[j].codigoColab = sColab[j + 1].codigoColab;
                            sColab[j].nomeColab = sColab[j + 1].nomeColab;
                            sColab[j].moradaColab = sColab[j + 1].moradaColab;
                            sColab[j].generoColab = sColab[j + 1].generoColab;
                            sColab[j].idadeColab = sColab[j + 1].idadeColab;
                            sColab[j].vencimentoColab = sColab[j + 1].vencimentoColab;
                        }
                        Array.Resize(ref sColab, sColab.Length - 1);
                        return;
                    }
                }
            }
        }

        static void ExtrairDocumentoCSV(sColaborador[] sColab)
        {
            // Função para extrair os dados dos colaboradores para um documento CSV
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine("Código,Nome,Morada,Género,Idade,Vencimento");
            for (int j = 0; j < sColab.Length; j++)
            {
                {
                    sb = sb.AppendLine($"{sColab[j].codigoColab}," +
                        $"{sColab[j].nomeColab}," +
                        $"{sColab[j].moradaColab}," +
                        $"{sColab[j].generoColab}," +
                        $"{sColab[j].idadeColab}," +
                        $"{sColab[j].vencimentoColab}");

                }
            }

            string filePath = @"C:\Users\vrocha\Documents\Colaboradores.csv";
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

            Console.WriteLine($"Documento CSV criado com sucesso e guardado em {filePath}");
        }

        static void LerDocumentoCSV(ref sColaborador[] sColab)
        {
            Console.WriteLine("A ler dados do ficheiro CSV...");

            string filePath = @"C:\Users\vrocha\Documents\Colaboradores.csv";

            try
            {
                string[] linhas = File.ReadAllLines(filePath);

                if (linhas.Length > 0)
                {
                    int novoTamanhoArray = sColab.Length + linhas.Length - 1;

                    sColaborador[] novoArray = new sColaborador[novoTamanhoArray];

                    Array.Copy(sColab, novoArray, sColab.Length);
                    
                    sColab = novoArray;

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] valores = linhas[i].Split(',');

                        int indice = sColab.Length - linhas.Length + i;

                        sColab[indice].codigoColab = int.Parse(valores[0]);
                        sColab[indice].nomeColab = valores[1];
                        sColab[indice].moradaColab = valores[2];
                        sColab[indice].generoColab = valores[3];
                        sColab[indice].idadeColab = int.Parse(valores[4]);
                        sColab[indice].vencimentoColab = double.Parse(valores[5]);
                    }

                    Console.WriteLine($"Foram adicionados {linhas.Length - 1} colaboradores ao array de colaboradores existente.");
                }
                else
                {
                    Console.WriteLine("O ficheiro CSV está vazio ou não contém dados para processar.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o ficheiro CSV: {e.Message}");
            }
        }
    }
}