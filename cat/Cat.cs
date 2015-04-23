using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    class Cat
    {
        //fields
        string color;
        int age;
        string breed;
        string size;

        //constructor
        public Cat (string color, int age, string breed, string size)
        {

            this.Color = color;
            this.Age = age;
            this.Breed = breed;
            this.Size = size;
        }

        //properties
        public string Color {set;get;}
       

        public int Age{set;get;}
        

        public string Breed{set;get;}
       

        public string Size{set;get;}
       
        //methods
        public string makeNoise ()

        {
                
            string noise = "meow";
            return noise;
        }

        public string willEat ()
        {

            string eat = "cat food";
            return eat;
        }

        }

    }

