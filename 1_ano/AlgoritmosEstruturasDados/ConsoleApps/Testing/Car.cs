using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Car
    {
        private string _name, _color;
        private int _hp;
        
        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "black";
        }
        
        // Partial specification Constructor
        public Car(string name, int hp = 0, string color = "black") {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine($"{name} was created");   
        }
        // Full Specification Constructor
        public Car(string name, string color, int hp)
        {
            _name = name;
            _color = color;
            _hp = hp;
            Console.WriteLine($"{name} was created");
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} can drive");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} stopped");
        }

        public void Details()
        {
            Console.WriteLine($"{_name} has {_hp} horse power and is {_color}");

        }
    }
}
