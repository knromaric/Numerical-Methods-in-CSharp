namespace Integration
{
    public static class TrapezoidalMethod
    {
        public static double SolveIntegration(double a, double b, int N)
        {
            double h = (b - a) / N;
            double sum = 0;
            sum += Function(a)+ Function(b);

            for (int i = 1; i < N; i++)
            {
                sum += 2 * Function(a + i * h);
            }

            return (h/2) * sum;
        }

        private static double Function(double x)
        {
            return x * x; 
        }
    }
}
