using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle : Figure
    {
        protected double width, height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("This is a triangle, its width: {0} and height: {1}", width, height);
        }
    }
    
}
