using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Triangle
    {
        private readonly int _rowsCount;
        private readonly int _totalCount;

        public Triangle(int index, int totalCount)
        {
            _rowsCount = index;
            _totalCount = totalCount;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (var i = 0; i < _rowsCount; i++)
            {
                result.AppendLine(
                    $"{new string(' ', _totalCount - i - 1)}{new string('*', i + 1)}{new string('*', i)}");
            }

            return result.ToString();
        }
    }
}
