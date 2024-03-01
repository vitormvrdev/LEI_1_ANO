namespace ArrayDeEstruturas
{   // Autor: Vitor Rocha
    // Array de estruturas de colaboradores
    internal class Program
    {
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
            Console.WriteLine("0 - Sair");
            Console.Write("Selecione uma opção: ");
            return Convert.ToInt16(Console.ReadLine());
        }
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
                }
            } while (opcao != 0);


        }
        static void InserirDadosColaborador(ref sColaborador[] sColab)
        {
            Console.WriteLine("Quantos colaboradores pretende inserir?");
            int numColab = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            // verificar o comprimento atual do array
            int tamanhoAtualArray = sColab.Length;
            // Guarda o valor novo do Array
            int novoTamanhoArray = tamanhoAtualArray + numColab;
            // Atrinui as novas posições ao array
            Array.Resize(ref sColab, novoTamanhoArray);
            int j = 1;
            // itera o ciclo até
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
            Console.WriteLine("De qual colaborador pretende alterar os dados?");

            int codigoColaborador = Convert.ToInt16(Console.ReadLine());

            if (!isValid(codigoColaborador, sColab)) // Verifica se o código existe senão pede um novo
            {
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
                        if (userEscolha1 == 2)
                        {
                            Console.WriteLine("----Alteração de dados de Colaborador----");
                            Console.WriteLine("Introduza novos dados");
                            Console.WriteLine("");
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
    }
}
