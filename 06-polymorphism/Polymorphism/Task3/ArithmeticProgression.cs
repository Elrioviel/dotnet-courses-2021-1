using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class ArithmeticProgression : IIndexableSeries
    {
        double startTerm, step;
        int currentIndex;
        public ArithmeticProgression(double startTerm, double step)
        {
            this.startTerm = startTerm;
            this.step = step;
            this.currentIndex = 1;
        }
        public double GetCurrent()
        {
            return startTerm + step * currentIndex;
        }
        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = 1;
        }
        public double this[int index]
        {
            get
            {
                return startTerm + step * index;
            }
        }
    }
    
}
