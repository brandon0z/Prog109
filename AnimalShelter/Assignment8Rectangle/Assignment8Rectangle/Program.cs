using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Instructions for Assignment 8
//Create a Rectangle class with height and width fields, a constructor, 
//    and getArea and getParameter methods. getArea calculates the area (area = height * width) 
//        and getParameter calculates the parameter (parameter = 2*(height + width).
//Create a rectangle object from the main method and call the getArea and getParameter methods.


namespace Assignment8Rectangle
{
   
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Rectangle Calculator");

            //Declare variables
            decimal height;
            decimal width;
            decimal area;
            decimal perimeter;

            //Prompt the user to enter value for height
            Console.WriteLine("Enter Rectangle height: ");
            height = int.Parse (Console.ReadLine());

            //Prompt the user to enter value for width
            Console.WriteLine("Enter Rectangle width: ");
            width = int.Parse(Console.ReadLine());

            //create a new rectangle object
            Rectangle R = new Rectangle(width, height);
            

            //Calls methods for area and perimeter
            area = R.GetArea(width, height);
            perimeter = R.GetPerimeter(width, height);

            //Displays the area and perimeter to console
            Console.WriteLine("The area of your rectangle is {0},", area);
            Console.WriteLine("The perimeter of your rectangle is {0},", perimeter);

            Console.ReadLine();
            
        }
    }
}
