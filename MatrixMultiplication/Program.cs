using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix1 =
            {
                {1,2},
                {3,4}
            };

            double[,] matrix2 =
            {
                {1,3},
                {5,6}
            };

            double[] vector1 = { 1, 2 };
            double[] vector2 = { 3, 4 };
            
            var vectorResult = Matrix.MatrixVectorMultiplication(matrix1, vector1);
            Console.WriteLine("Matrix vector multiplication......");
            Matrix.DisplayVector(vectorResult);

            Console.WriteLine();
            var finalResult = Matrix.Multiply(matrix1, matrix2);
            Console.WriteLine("Matrix multiplication......");
            Matrix.DisplayMatrix(finalResult);

            Console.WriteLine();
            Console.WriteLine("Dot product multiplication");
            Console.WriteLine($"Dot Product : {Matrix.DotProduct(vector1, vector2)}");
        }
    }
}
