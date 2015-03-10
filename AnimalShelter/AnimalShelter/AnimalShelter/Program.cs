using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my animal shelter!");

            Console.WriteLine("What is your favorite animal?");

            string favoriteAnimal = Console.ReadLine().ToLower();

            // Add code to check for plural case and if not add "s" to the string favoriteAnimal

            Console.WriteLine("I love {0}!", favoriteAnimal);
            Console.WriteLine("Lets adopt several {0}.", favoriteAnimal);
            Console.WriteLine("{0} are such wonderful animals.", favoriteAnimal);
            
            Console.ReadLine();

        }
    }
}
