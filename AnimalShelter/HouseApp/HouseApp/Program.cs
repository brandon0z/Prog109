using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseApp
{

    class Program
    {

        public void Play()
        {

            Console.WriteLine("Welcome to the House App");

            House[] houses = new House[3];

            houses[0] = new House("Blue", 2, false);

            houses[1] = new House("Yellow", 4, true);

            houses[2] = new House("Beige", 5, true);

            //loop through all the houses, and display them

            for (int i = 0; i < houses.Length; i++)
            {

                Console.WriteLine(houses[i].GetDetails() +

                " for $" + houses[i].GetPrice());

            }

            Console.ReadLine(); //keep the Console open

        }

        static void Main(string[] args)
        {

            Program street = new Program();

            street.Play();

        }

    }

}
