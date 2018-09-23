using System;

namespace RootFinding
{
    public class BissectionMethod
    {
        private const double EPSILON = 1e-10;

       public double FindMethod(double xPositive, double xNegative)
       {
            double root = 0; 
            while(Math.Abs(xPositive-xNegative) > EPSILON)
            {
                root = (xPositive + xNegative) / 2; 

                if(Function(root) > 0)
                {
                    xPositive = root; 
                }
                else 
                {
                    xNegative = root;
                }
            }

            return root; 
       }

       private double Function(double x)
       {
            return x * x - 2; 
       }

    }
}
