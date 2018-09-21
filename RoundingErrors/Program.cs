using System;

namespace RoundingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10;
            double sum = 0;

            for (int i = 0; i < 100; i++)
            {
                sum = sum + .1; 
            }

            // bad way to compare floating point
            Console.WriteLine(sum == num1); 

            double epsilon = 0.000000001; // error depends on the accuracy we want.

            if(Math.Abs(sum - num1) < epsilon)
                Console.WriteLine("They are Equals...");
            else
                Console.WriteLine("They are not equals...");

        }
    }
}
 