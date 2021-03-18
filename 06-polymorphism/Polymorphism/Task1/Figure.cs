using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Figure
    {
        public string FigureType { get; set; }
        public abstract void Draw();
    }
}
