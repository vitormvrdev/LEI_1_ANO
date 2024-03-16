namespace TestingAroundWithCsharp
{
    class CursoC_
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza um número: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {

            }
        }
    }
}
