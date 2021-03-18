using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GeometricProgression : ISeries
    {
        int start, commonRatio, currentIndex;
        public GeometricProgression(int start, int commonRatio)
        {
            this.start = start;
            this.commonRatio = commonRatio;
            this.currentIndex = 0;
        }
        public int GetCurrent()
        {
                return  start * (int)Math.Pow(commonRatio, currentIndex);
            
        }
        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
