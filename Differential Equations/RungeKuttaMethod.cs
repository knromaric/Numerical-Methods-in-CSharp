using System;

namespace Differential_Equations
{
    public class RungeKuttaMethod
    {
        private static double x; 
        private static double y = 1;
        private static readonly double dx = 0.1;
        private static double k1;
        private static double k2;
        private static double k3;
        private static double k4;
        private static readonly double ratio = 1.0 / 6.0;

        public static void Solve()
        {
            while (x < 10)
            {
                k1 = dx * Function(x, y);
                k2 = dx * Function(x+dx/2, y+dx*k1/2);
                k3 = dx * Function(x + dx / 2, y+dx*k2/2);
                k4 = dx * Function(x+dx, y+dx*k3);

                y = y + ratio * (k1 + 2 * k2 + 2 * k3 + k4);

                Console.WriteLine($"{x}, {y}");
                x = x + dx;
            }
        }

        private static double Function(double x, double y)
        {
            return x * y;
        }
    }
}
