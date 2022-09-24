using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsSubAssignment
{
    public class CalculationOfSquare
    {
        // Creating 3 methods
        public int perimeterOfSquare (int side)
        {
            int result = 4*side;
            return result;
        }

        public int areaOfSquare(int side)
        {
            int result = side * side;
            return result;
        }

        public int diagonalOfSquare(int side)
        {
            double diagonal = side * Math.Sqrt(2);
            return (int)diagonal;
        }

    }
}
