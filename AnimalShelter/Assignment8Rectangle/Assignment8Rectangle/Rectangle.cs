using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8Rectangle
{
    class Rectangle
    {
        //fields
        private decimal height;
        private decimal width;

        //constructor
        //public Rectangle();
        public Rectangle(decimal height, decimal width)
        {
            this.Height = height;
            this.Width = width;
        }

        //properties - Future work to use error checking to ensure positive numbers for height and width
        public decimal Height { get; set; }

        public decimal Width { get; set; }

        //methods
        public decimal GetArea(decimal width, decimal height)
        {
            decimal area = height * width;
            return area;
        }

        public decimal GetPerimeter(decimal width, decimal height)
        {
            decimal perimeter = 2 *(width + height);
            return perimeter;
        }
    }
}
