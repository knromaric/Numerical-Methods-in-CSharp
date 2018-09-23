namespace Integration
{
    public static class RectangleMethod
    {
        public static double SolveIntegration(double a, double b, int N)
        {
            double h = (b - a) / N;
            double sum = 0;
            for (int i = 0; i < N-1; i++)
            {
                sum += Function(a + i * h);
            }

            return h * sum; 
        }

        private static double Function(double x)
        {
            return x * x;
        }
    }
}
