using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ring : Round
    {
        protected double innerRadius;
        public Ring(double innerRadius, double radiusRound) : base(radiusRound)
        {
            this.innerRadius = innerRadius;
        }
        public override void Draw()
        {
            Console.WriteLine("This is a ring with inner radius = {0} and outer radius = {1}", innerRadius, radiusRound);
        }
    }
}
