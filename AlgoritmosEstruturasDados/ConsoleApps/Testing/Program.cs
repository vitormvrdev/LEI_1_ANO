using System.Runtime.Serialization;

namespace Testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car audi = new Car();

            audi.Drive();
            audi.Stop();
        }
    }
}
