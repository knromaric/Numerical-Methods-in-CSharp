using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSystems
{
    public class GaussianElimination
    {
        public double[] Solve(double[,] matrix, double[] vector)
        {
            int dim = matrix.GetLength(0);

            for (int row = 0; row < dim; row++)
            {
                //searching the pivot: partial pivoting
                int max = row;
                for (int col = row+1; col < dim; col++)
                {
                    if(Math.Abs(matrix[col, row]) > Math.Abs(matrix[max, row]))
                    {
                        max = col;
                    }   
                }
            }
        }
    }
}
