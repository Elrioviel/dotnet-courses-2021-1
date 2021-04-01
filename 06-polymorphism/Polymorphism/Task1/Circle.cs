using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle : Figure
    {
        
        protected double radiusCircle;
        public Circle(double radiusCircle)
        {
            this.radiusCircle = radiusCircle;
            this.FigureType = "cirlce";
        }
        public override void Draw()
        {
            Console.WriteLine("This is a {0}. Radius: {1}", FigureType, radiusCircle);
        }
    }
}
