using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        //Person object properties
        string color, make, gearBox;

        /*----- Getters and Setters -----*/
        //Standard getters and setters
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string GearBox
        {
            get
            {
                return gearBox;
            }
            set
            {
                gearBox = value;
            }
        }

        //Constructor
        public Person(string _color, string _make, string _gearBox)
        {
            //ensure your referncing the setter and not the property
            Color = _color;
            Make = _make;
            GearBox = _gearBox;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            //One way to create a Person object while theres a constructor
            Person car1 = new Person("", "", "");
            Console.WriteLine("Enter new car details below");
            Console.Write("Color: ");
            string _color = Console.ReadLine();

            Console.Write("Make: ");
            string _make = Console.ReadLine();

            Console.Write("Gear Box: ");
            string _gearBox = Console.ReadLine();

            Console.WriteLine("This car is a " + _color + " " + _make + " with a " + _gearBox + " transmission");
            Console.ReadLine();


        }
    }
}
