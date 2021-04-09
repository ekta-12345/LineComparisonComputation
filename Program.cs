using System;

namespace LineComparisonComputation
{
    class ComparisonLines
    {
        static void Main(string[] args)
        {
            //for line1
            Console.WriteLine("Enter the value of x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            //for line2
            Console.WriteLine("Enter the value of z1:");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of z2:");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of k1:");
            int k1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of k2:");
            int k2 = Convert.ToInt32(Console.ReadLine());

            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);  // Calculate LenghthofLine1 using Math.Sqrt formula
            double LengthofLine2 = Math.Sqrt((z2 - z1) ^ 2 + (k2 - k1) ^ 2);  // // Calculate LenghthofLine2 using Math.Sqrt formula
            Console.WriteLine("Length of (x, y) co-ordinates :  " + LengthofLine1);  // Display Length1
            Console.WriteLine("Length of (z, k) co-ordinates :  " + LengthofLine2);  // Display Length2

            double Result = LengthofLine1.CompareTo(LengthofLine2);  //compareTo method to compare 2 Lengths is LengthofLine1 and LengthofLine2
            Console.WriteLine(Result);
            if (Result == 0)                       //  linea are equal 
            {
                Console.WriteLine("Two Lines are equal ");
            }
            else if (Result > 0)    //greater than the other line.
            {
                Console.WriteLine("Line one is Greater than line Two");
            }
            else
            {
                Console.WriteLine("Line one is Smaller than Line two");
            }

        }
    }
}
