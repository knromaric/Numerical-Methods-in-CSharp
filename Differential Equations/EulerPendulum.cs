using System;

namespace Differential_Equations
{
    /// <summary>
    /// Using the euler method to solve the pendulum problem
    /// </summary>
    public static class EulerPendulum
    {
        private static double t;
        private static double v = 1;
        private static readonly double dt = 0.1;
        private static double x = 0;
        private static readonly double g = 9.8;
        private static readonly double l = 1; 

        public static void Solve()
        {
            while (t < 100)
            {
                v = v + dt * Function(t, x);
                x = x + v * dt;
                Console.WriteLine($"{t} , {x}");
                t = t + dt;
            } 
        }

        private static double Function(double t, double x)
        {
            return -(g / l) * x;
        }

    }
}
