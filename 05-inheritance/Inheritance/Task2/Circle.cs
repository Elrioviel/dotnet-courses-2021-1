using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Circle 
    {
        private Round innerround;// _innerRadius;
        private Round outerround;

        public Circle(int xValue, int yValue, int radiusValue, int InnerRadius)
        {
            if ((InnerRadius > radiusValue) || (InnerRadius < 0))
            {
                throw new ArgumentException("Radius must be greater than the inner radius!");
            }
            this.innerround = new Round (xValue, yValue, InnerRadius);
            this.outerround = new Round(xValue, yValue, radiusValue);
        }
        public double CalculateAreaDifferencee()
        {
            return outerround.CalculateArea()- innerround.CalculateArea();
        }

        public double CalculateSumCirclePerimeter()
        {
            return innerround.CalculatePerimeter() + outerround.CalculatePerimeter();
        }

        

    }
}
