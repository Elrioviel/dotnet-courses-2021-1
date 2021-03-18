using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Figure
    {
        protected double radiusRound;
        public Round(double radiusRound)
        {
            this.radiusRound = radiusRound;
        }
        public override void Draw()
        {
            Console.WriteLine("This is a round shape with radius = {0}", radiusRound);
        }
    }
}
