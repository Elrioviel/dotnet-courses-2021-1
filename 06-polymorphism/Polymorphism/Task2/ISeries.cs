using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    interface ISeries
    {
        int GetCurrent();
        bool MoveNext();
        void Reset();

        
    }
}
