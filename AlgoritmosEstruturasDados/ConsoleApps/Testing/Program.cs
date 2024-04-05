using System.Runtime.Serialization;

namespace Testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            Car audi = new Car("audi", 350);
            Car bmw = new Car("BMW", 500, "blue");

            bmw.Drive();
            audi.Drive();

            Console.WriteLine("Press 1 to stop the cars!");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                audi.Stop();
                bmw.Stop();
            }
            else
            {
                Console.WriteLine("They will drive forever.....");
            }


            audi.Details();
            bmw.Details();
            myCar.Details();
        }
    }
}
