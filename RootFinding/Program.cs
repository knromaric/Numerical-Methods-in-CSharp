using System;

namespace RootFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            var bissection = new BissectionMethod();
            var newton = new NewtonMethod();
            Console.WriteLine($"Root found using the bissection Method: { bissection.FindMethod(2, 1)}");
            Console.WriteLine($"Root found using the NewTon Raphson Method: { newton.Find(1)}");
            Console.WriteLine($"the square root of 2 is : {Math.Sqrt(2)}");
        }
    }
}
