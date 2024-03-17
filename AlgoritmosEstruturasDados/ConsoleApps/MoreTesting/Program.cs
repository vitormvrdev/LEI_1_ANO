namespace MoreTesting
{
    internal class TRYPARSE
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";

            bool canParse = int.TryParse(numberAsString, out int parsedValue);

            // returns true if the parsing is successful

            if (canParse)
            {
                Console.WriteLine($"Parsing successful - number is {parsedValue}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }
        }
    }
}
