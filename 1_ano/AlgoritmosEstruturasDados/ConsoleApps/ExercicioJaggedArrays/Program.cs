namespace ExercicioJaggedArrays
{
    internal class Program
    {//Ricardo Moura 17/04/2024
        struct Student
        {
            public string nome;
            public int[][] uc; //Unidade Curricular
        }
        static void Main(string[] args)
        {
            //Variaveis
            Student[] aStudents = new Student[2];

            InserirAluno(ref aStudents);
            ListarDados(aStudents);

            /*
            aStudents[0] = new Student();
            aStudents[0].uc = new int[3][]; // 3 Disciplinas
            aStudents[0].nome = "Maria";
            aStudents[0].uc[0] = new int[] { 12, 15, 7, 9 };
            aStudents[0].uc[1] = new int[] { 12, 15 };
            aStudents[0].uc[2] = new int[] { 12, 18, 20, 14, 17 };

            aStudents[1] = new Student();
            aStudents[1].uc = new int[2][]; // 3 Disciplinas

            aStudents[1].nome = "Ricardo";
            aStudents[1].uc[0] = new int[] { 12 };
            aStudents[1].uc[1] = new int[] { 12, 15, 17 };

            //listagem
            Console.WriteLine("Listagem de Alunos");
            //inserção dos valores com FORs
            */
        }
        static void ListarDados(Student[] aStudents)
        {

            Console.WriteLine("----------------------");
            Console.WriteLine("-------Listagem-------");
            Console.WriteLine("----------------------");

            for (int i = 0; i < aStudents.Length; i++)
            {
                Console.WriteLine($"Aluno: {aStudents[i]}");
                for (int j = 0; j < aStudents[i].uc.Length; j++)
                {
                    Console.WriteLine($"Cadeira: {aStudents[i].uc[j]}");
                    for (int k = 0; k < aStudents[i].uc[j].Length; k++)
                    {
                        Console.WriteLine($"{k + 1}ª nota: {aStudents[i].uc[j][k]}");
                    }
                }

            }


            Console.WriteLine("Pressione ENTER p/ continuar.");
            Console.ReadKey();
        }
        static void InserirAluno(ref Student[] aStudents)
        {
            for (int i = 0; i < aStudents.Length - 1; i++)
            {
                aStudents[i] = new Student();

                Console.WriteLine($"Introduza o nome do {i + 1}º aluno: ");
                aStudents[i].nome = Console.ReadLine();

                Console.WriteLine("Quantas Unidades curriculares pretende inserir?");
                int nCadeiras = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");

                aStudents[i].uc = new int[nCadeiras][];

                for (int j = 0; j < nCadeiras; j++)
                {
                    Console.WriteLine($"Introduza o número de notas ");
                    int nNotas = Convert.ToInt16(Console.ReadLine());

                    aStudents[i].uc[j] = new int[nNotas];
                    for (int k = 0; k < nNotas; k++)
                    {
                        Console.WriteLine($"Introduza a {k + 1}ª nota: ");
                        aStudents[i].uc[j][k] = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }
        }
    }
}
