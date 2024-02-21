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

        static void Menu()
        {
            return;
        }
        static void Main(string[] args)
        {
            sColaborador sColab = new sColaborador();

            Console.WriteLine("Gestão de Colaboradores");

            Console.Write("Inserir o código: ");
            sColab.codigoColab = Convert.ToInt16(Console.ReadLine());

            Console.Write("Inserir o nome: ");
            sColab.nomeColab = Console.ReadLine();

            Console.Write("Inserir o morada: ");
            sColab.moradaColab = Console.ReadLine();

            Console.Write("Inserir o genero: ");
            sColab.generoColab = Console.ReadLine();

            Console.Write("Inserir o idade: ");
            sColab.idadeColab = Convert.ToInt16(Console.ReadLine());

            Console.Write("Inserir o vencimento: ");
            sColab.vencimentoColab = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*** Apresentação da Estrutura***");

            Console.WriteLine($"Código: {sColab.codigoColab}\n" +
                $"Nome: {sColab.nomeColab}\n" +
                $"Morada: {sColab.moradaColab}\n" +
                $"Género: {sColab.generoColab}\n" +
                $"Idade: {sColab.idadeColab}\n" +
                $"Vencimento: {sColab.vencimentoColab}\n");
        }
    }
}
