namespace MoreTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza um número: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            } catch (Exception ex)
            {
                Console.WriteLine("Introduza um número do tipo correto");   
            }
        }
    }
}
