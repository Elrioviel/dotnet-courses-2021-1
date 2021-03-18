using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> fig = new List<Figure>();
            fig.Add(new Circle(15.65));
            fig.Add(new Line(19.78));
            fig.Add(new Rectangle(26.96, 17.98));
            fig.Add(new Round(26.00));
            fig.Add(new Ring(21.25, 26.00));

            foreach (Figure figure in fig)
            {
                figure.Draw();
            }

            Console.ReadKey();
            
        }
    }
}
