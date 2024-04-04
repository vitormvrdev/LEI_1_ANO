using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Car
    {
        // Constructor
        public Car() {
            Console.WriteLine("Car was created");   
        }

        public void Drive()
        {
            Console.WriteLine("Car can drive");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }
}
