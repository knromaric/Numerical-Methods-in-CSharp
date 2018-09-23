using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public static class MonteCarloIntegration
    {
        private static Random random = new Random();

        public static double SolveIntegration(double a, double b, int numOfIntegrations)
        {
            double underFunctionCounter = 0;

            for (int i = 0; i < numOfIntegrations; i++)
            {
                double randomX = GetRandom(a, b);
                double randomY = GetRandom(a, b);

                if (IsUnder(randomX, randomY))
                {
                    underFunctionCounter++;
                }
            }

            return GetTotal(a, b) * (underFunctionCounter / numOfIntegrations);
        }

        private static double GetTotal(double a, double b)
        {
            return (b - a) * (b - a);
        }

        private static bool IsUnder(double x, double y)
        {
            if (y < Function(x))
                return true;

            return false;
        }

        private static double Function(double x)
        {
            return x * x;
        }
        private static double GetRandom(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
