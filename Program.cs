using System;

namespace LineComparisonComputation
{
    class ModelCartesian
    {
        static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("Enter the value of x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of (x, y)co-ordinates : " + length);


        }
    }
}
