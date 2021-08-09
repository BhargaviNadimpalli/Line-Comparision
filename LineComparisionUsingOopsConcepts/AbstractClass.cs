using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionUsingOopsConcepts
{
    abstract class AbstractClass
    {
        public abstract double LengthOfLine1();
        public abstract double LengthOfLine2();
    }
    class LineComparision : AbstractClass
    {
        public double x1, x2, y1, y2;
        public double x3, x4, y3, y4;
        public LineComparision()
        {
            x1 = 2;
            x2 = 3;
            y1 = 1;
            y2 = 3;
            x3 = 6;
            x4 = 2;
            y3 = 3;
            y4 = 2;
        }
        public override double LengthOfLine1()
        {
            double length1 = x2 - x1;
            double length2 = y2 - y1;
            double LengthOfLine1 = Math.Sqrt(Math.Pow(length1, 2) + Math.Pow(length2, 2));
            return LengthOfLine1;
        }
        public override double LengthOfLine2()
        {
            double length3 = x4 - x3;
            double length4 = y4 - y3;
            double LengthOfLine2 = Math.Sqrt(Math.Pow(length3, 2) + Math.Pow(length4, 2));
            return LengthOfLine2;
        }
    }
}
