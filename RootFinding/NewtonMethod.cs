namespace RootFinding
{
    public class NewtonMethod
    {
        private const int ITERATIONS = 5; 

        public double Find(double initialRoot)
        {
            for (int iterationCounter= 0; iterationCounter < ITERATIONS; iterationCounter++)
            {
                initialRoot = initialRoot -( Function(initialRoot) / DerivativeFunction(initialRoot));
            }

            return initialRoot; 
        }

        private double Function(double x)
        {
            return x * x - 2;
        }

        private double DerivativeFunction(double x)
        {
            return 2 * x;
        }
    }
}
