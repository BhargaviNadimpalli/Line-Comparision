using System;

namespace LineComparisionUsingOopsConcepts
{
    class Program
    { 
       
            
            static void Main(string[] args)
        {
            LineComparision obj1 = new LineComparision();
            LineComparision obj2 = new LineComparision();
            double line1 = obj1.LengthOfLine1();
            double line2 = obj2.LengthOfLine2();
            Console.WriteLine("The length of first co-ordinates :" + line1);
            Console.WriteLine("The length of second co-ordinates :" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("The length1 and length2 are equal");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("The length1 is greater than length2");

            }
            else
            {
                Console.WriteLine("The length1 is less than length2");
            }
        }
    }
    }


