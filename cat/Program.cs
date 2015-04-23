using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat1, cat2, cat3;

            cat1 = new Cat("black", 12, "Siamese", "big");
            cat2 = new Cat("white", 10, "American Curl", "medium");
            cat3 = new Cat("tabby", 8, "Siberian", "small");

            Console.WriteLine("Properties for our first cat is: " + "\n" + "Color: " + cat1.Color + "\n" + "Age: " + cat1.Age + "\n" + "Breed: " + cat1.Breed + "\n" + "Size: " + cat1.Size + "\n");
            Console.WriteLine("Properties for our second cat is: " + "\n" + "Color: " + cat2.Color + "\n" + "Age: " + cat2.Age + "\n" + "Breed: " + cat2.Breed + "\n" + "Size: " + cat2.Size + "\n");
            Console.WriteLine("Properties for our third cat is: " + "\n" + "Color: " + cat3.Color + "\n" + "Age: " + cat3.Age + "\n" + "Breed: " + cat3.Breed + "\n" + "Size: " + cat3.Size + "\n");
            
            
            string eat = cat1.willEat();
            string noise = cat1.makeNoise();

           

            Console.WriteLine("My cat will eat " + eat);
            Console.WriteLine("My cat says " + noise);
            
            Console.ReadLine();
        }
    }
}
