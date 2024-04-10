using System.Xml;

namespace EstruturasComArrays
{
    struct Aluno
    {
        public string nome;
        public Disciplina[] disciplinas;
    }

    struct Disciplina 
    {
        public int codigo;
        public string designacao;
        public double nota;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAlunos = 3;
            int numDisciplinas = 4;

            Aluno[] alunos = new Aluno[numAlunos];
            Disciplina[] disciplinas = new Disciplina[numDisciplinas];

            do
            {
                SwitchCase(ref alunos, ref disciplinas);
            }while (Menu() != 0);
        }

        static int Menu()
        {
            Console.WriteLine("-------Menu-------");
            Console.WriteLine("1-Introduzir Dados Alunos");
            Console.WriteLine("2-Introduzir Dados Disciplinas");
            Console.WriteLine("3-Ver Dados");
            Console.WriteLine("0-Sair");
            return Convert.ToInt16(Console.ReadLine());
        }

        static void SwitchCase(ref Aluno[] alunos,ref Disciplina[] disciplinas)
        {
            switch (Menu())
            {
                case 1:
                    IntroduzirDadosAlunos(ref alunos, ref disciplinas);
                    break;
                case 2:
                    IntroduzirDadosDisciplinas(ref disciplinas);
                    break;
                case 3:
                    ListarAlunos(alunos);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        static void IntroduzirDadosAlunos(ref Aluno[] alunos, ref Disciplina[] disciplinas)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write($"Escreve o nome do {i + 1} aluno: ");
                alunos[i].nome = Console.ReadLine();
                alunos[i].disciplinas = disciplinas;

                for (int j = 0; j < alunos[i].disciplinas.Length; j++)
                {
                    Console.WriteLine($"Disciplina: {alunos[i].disciplinas[j].codigo}");
                    Console.WriteLine($"Disciplina: {alunos[i].disciplinas[j].designacao}");
                    Console.WriteLine("Qual a nota? ");
                    alunos[j].disciplinas[j].nota = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void IntroduzirDadosDisciplinas(ref Disciplina[] disciplinas)
        {
            for (int i = 0; i < disciplinas.Length; i++)
            {
                Console.Write($"Escreve o código da disciplina {i + 1}:");
                disciplinas[i].codigo = Convert.ToInt16(Console.ReadLine());
                Console.Write($"Designação: ");
                disciplinas[i].designacao = Console.ReadLine();
            }
        }

        static void ListarAlunos(Aluno[] alunos)
        {
            Console.WriteLine("Listagem de alunos");
            for (int k = 0; k < alunos.Length; k++)
            {
                Console.WriteLine($"Aluno {alunos[k].nome}");
                for (int z = 0; z < alunos[k].disciplinas.Length; z++)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
