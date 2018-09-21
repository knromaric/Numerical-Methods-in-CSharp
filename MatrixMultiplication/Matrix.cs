using System;

namespace MatrixMultiplication
{
    public class Matrix
    {
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            int dimension = matrix1.GetLength(0);
            var result = new double[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    for (int k = 0; k < dimension; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result; 
        }

        public static double[] MatrixVectorMultiplication(double[,] matrix, double[] vector)
        {
            double[] result = new double[vector.Length];

            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    result[i] += matrix[i, j] * vector[j];
                }
            }

            return result; 
        }

        public static double DotProduct(double[] vector1, double[] vector2)
        {
            double result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }

            return result; 
        }
        public static void DisplayMatrix(Double[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayVector(Double[] vector)
        {
            for (int j = 0; j < vector.Length; j++)
            {
                Console.WriteLine($"{vector[j]} ");
            }

        }
    }
}
