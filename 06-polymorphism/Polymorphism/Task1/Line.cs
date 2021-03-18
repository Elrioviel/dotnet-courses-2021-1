using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
        protected double length;
        public Line(double length)
        {
            this.length = length;
        }
        public override void Draw()
        {
            Console.WriteLine("This is a line, its length: {0}", length);
        }
    }
}
