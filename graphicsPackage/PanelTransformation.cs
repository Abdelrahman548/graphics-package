using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicsPackage
{
    internal class PanelTransformation
    {
        List<List<List<int>>> points;

        public PanelTransformation(List<List<List<int>>> p)
        {
            points = p;
        }
        
        
        private int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("Matrices cannot be multiplied. Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
        private double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("Matrices cannot be multiplied. Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }

            double[,] result = new double[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public List<List<List<int>>> Translate(int dx, int dy)
        {
            int[,] matrix = {   {1, 0, dx},
                                {0, 1, dy },
                                {0, 0, 1 }
            };
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points[i].Count; j++)
                {
                    int[,] point = { { points[i][j][0] }, { points[i][j][1] }, { 1 } };

                    int[,] result = MultiplyMatrices(matrix, point);
                    points[i][j][0] = result[0, 0];
                    points[i][j][1] = result[1, 0];
                }
            }
            
            return points;
        }

        public List<List<List<int>>> Rotate(int degree)
        {
            double angleRad = degree * Math.PI / 180.0; // Convert degrees to radians

            double[,] matrix = {{Math.Cos(angleRad), -Math.Sin(angleRad), 0},
                                {Math.Sin(angleRad),  Math.Cos(angleRad), 0},
                                {0                 ,        0           , 1 }
                                };
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points[i].Count; j++)
                {
                    double[,] point = { { points[i][j][0] }, { points[i][j][1] }, { 1 } };

                    double[,] result = MultiplyMatrices(matrix, point);
                    points[i][j][0] = (int)result[0, 0];
                    points[i][j][1] = (int)result[1, 0];
                }
            }

            return points;
        }

        public List<List<List<int>>> Scale(double sx, double sy)
        {
            double[,] matrix = {
                                {sx, 0, 0},
                                {0, sy, 0},
                                {0, 0, 1}
                            };

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points[i].Count; j++)
                {
                    double[,] point = { { points[i][j][0] }, { points[i][j][1] }, { 1 } };

                    double[,] result = MultiplyMatrices(matrix, point);

                    points[i][j][0] = (int)result[0, 0];
                    points[i][j][1] = (int)result[1, 0];
                }
            }

            return points;
        }

        public List<List<List<int>>> Shear(double shx, double shy)
        {
            // Define the shearing matrix
            double[,] matrix = { {1, shx, 0},
                                 {shy, 1, 0},
                                 {0  , 0, 1}
                                };

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points[i].Count; j++)
                {
                    double[,] point = { { points[i][j][0] }, { points[i][j][1] }, { 1 } };

                    double[,] result = MultiplyMatrices(matrix, point);
                    points[i][j][0] = (int)result[0, 0];
                    points[i][j][1] = (int)result[1, 0];
                }
            }

            return points;

        }

        public List<List<List<int>>> Reflect(double sx, double sy)
        {
            if (Math.Abs(sx) == 1 && Math.Abs(sy) == 1)
                return Scale(sx, sy);
            else
                return points;
        }
    }
}
