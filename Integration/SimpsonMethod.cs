using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public static class SimpsonMethod
    {
        public static double SolveIntegration(double a, double b, int N)
        {
            double h = (b - a) / N;
            double sum = 0;

            sum += Function(a) + Function(b);

            for (int i = 1; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 2 * Function(a + i * h);
                }
                else
                {
                    sum += 4 * Function(a + i * h);
                }
            }

            return (h / 3) * sum;

        }

        private static double Function(double x)
        {
            return x * x;
        }
    }
}
