using System;

namespace Differential_Equations
{
    public static class EulerMethod
    {
        private static double _x = 0;
        private static double _y = 1;
        private static readonly double _h = 0.01;

        public static void Solve()
        {
            while(_x < 10)
            {
                _y = _y + _h * Function(_x, _y);
                Console.WriteLine($"{_x} , {_y}");
                _x = _x + _h;
            }

        }

        private static double Function(double x, double y)
        {
            return Math.Cos(x);
        }
    }
}
