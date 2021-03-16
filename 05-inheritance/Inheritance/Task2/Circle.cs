using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Circle : Round
    {
        private int _innerRadius;
        public int InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                _innerRadius = value;
            }
        }

        public Circle(int xValue, int yValue, int radiusValue, int InnerRadius) : base(xValue, yValue, radiusValue)
        {
            if ((InnerRadius > radiusValue) || (InnerRadius < 0))
            {
                throw new ArgumentException("Radius must be greater than the inner radius!");
            }
            this.InnerRadius = InnerRadius;
        }
        public static double CalculateCircleArea(int xValue, int yValue, int InnerRadius)
        {
            double circleArea = Math.PI * InnerRadius * InnerRadius;
            return circleArea;
        }

        public static double CalculateCirclePerimeter(int InnerRadius)
        {

            double circleCircumference = 2 * Math.PI * InnerRadius;
            return circleCircumference;
        }

        public static double CalculateSumCircumferences(double circumference, double circleCircumference)
        {
            double sumOfCircumferences = circumference + circleCircumference;
            return sumOfCircumferences;
        }

    }
}
