using System;

namespace Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integration calculation of a function x^2 using : ");
            Console.WriteLine($"- Rectangle Method between 0 and 1: {RectangleMethod.SolveIntegration(0, 1, 100)}");
            Console.WriteLine($"- Trapezoidal Method between 0 and 1: {TrapezoidalMethod.SolveIntegration(0, 1, 100)}");
            Console.WriteLine($"- Simpson Method between 0 and 1: {SimpsonMethod.SolveIntegration(0, 1, 100)}");
            Console.WriteLine($"- Monte Carlo Method between 0 and 1: {MonteCarloIntegration.SolveIntegration(0, 1, 1000)}");
        }
    }
}
