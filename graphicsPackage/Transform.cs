using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicsPackage
{
    struct PointColor
    {
        public int X;
        public int Y;
        public Color Color;

        public PointColor(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
    internal class Transform
    {
        Bitmap image;
        List<PointColor> points;
        public Transform(Bitmap newImage)
        {
            image = newImage;
            points = new List<PointColor>();
            getPoints();
        }
        private void getPoints()
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    points.Add(new PointColor(x, y, pixelColor));
                }
            }
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

        public Bitmap Translate(int dx, int dy)
        {
            if (Math.Abs(dx) >= image.Width || Math.Abs(dy) >= image.Height)
            {
                throw new ArgumentException("Translation value must be within image bounds.");
            }

            Bitmap transformedImage = new Bitmap(image.Width, image.Height);
            int[,] matrix = {   {1, 0, dx},
                                {0, 1, dy },
                                {0, 0, 1 }
            };
            for (int i = 0; i < points.Count; i++)
            {
                PointColor p = points[i];
                int[,] point = { { p.X }, { p.Y }, { 1 } };

                int[,] result = MultiplyMatrices(matrix, point);

                points[i] = new PointColor(result[0, 0], result[1, 0], p.Color);
            }
            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < image.Width && point.Y >= 0 && point.Y < image.Height)
                {
                    transformedImage.SetPixel(point.X, point.Y, point.Color);
                }
            }
            return transformedImage;
        }

        public Bitmap Rotate(int degree)
        {
            double angleRad = -degree * Math.PI / 180.0; // Convert degrees to radians

            Bitmap transformedImage = new Bitmap(image.Width, image.Height);
            double[,] matrix = {{Math.Cos(angleRad), -Math.Sin(angleRad), 0},
                                {Math.Sin(angleRad),  Math.Cos(angleRad), 0},
                                {0                 ,        0           , 1 }
                                };
            for (int i = 0; i < points.Count; i++)
            {
                PointColor p = points[i];
                double[,] point = { { p.X }, { p.Y }, { 1 } };

                double[,] result = MultiplyMatrices(matrix, point);

                points[i] = new PointColor((int)Math.Round(result[0, 0]), (int)Math.Round(result[1, 0]), p.Color);
            }
            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < image.Width && point.Y >= 0 && point.Y < image.Height)
                {
                    transformedImage.SetPixel(point.X, point.Y, point.Color);
                }
            }
            return transformedImage;
        }

        public Bitmap Scale(double sx, double sy)
        {
            // Calculate the new dimensions of the scaled image
            //int newWidth = (int)Math.Round(image.Width * Math.Abs(sx));
            //int newHeight = (int)Math.Round(image.Height * Math.Abs(sy));

            int newWidth = image.Width;
            int newHeight = image.Height;

            Bitmap transformedImage = new Bitmap(newWidth, newHeight);

            double[,] matrix = {    {sx, 0, 0},
                                    {0, sy, 0},
                                    {0, 0, 1 }
                                };
            for (int i = 0; i < points.Count; i++)
            {
                PointColor p = points[i];
                double[,] point = { { p.X }, { p.Y }, { 1 } };

                double[,] result = MultiplyMatrices(matrix, point);

                points[i] = new PointColor((int)Math.Round(result[0, 0]), (int)Math.Round(result[1, 0]), p.Color);
            }
            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < newWidth && point.Y >= 0 && point.Y < newHeight)
                {
                    transformedImage.SetPixel(point.X, point.Y, point.Color);
                }
            }
            return transformedImage;
        }

        public Bitmap Shear(double shx, double shy)
        {
            // Create a new bitmap for the transformed image
            Bitmap transformedImage = new Bitmap(image.Width, image.Height);

            // Define the shearing matrix
            double[,] matrix = { {1, shx, 0},
                                 {shy, 1, 0},
                                 {0  , 0, 1}
                                };

            // Apply shearing transformation to each point
            for (int i = 0; i < points.Count; i++)
            {
                PointColor p = points[i];
                double[,] point = { { p.X }, { p.Y }, { 1 } };

                double[,] result = MultiplyMatrices(matrix, point);

                points[i] = new PointColor((int)Math.Round(result[0, 0]), (int)Math.Round(result[1, 0]), p.Color);
            }

            // Render transformed points onto the new image
            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < image.Width && point.Y >= 0 && point.Y < image.Height)
                {
                    transformedImage.SetPixel(point.X, point.Y, point.Color);
                }
            }

            return transformedImage;
        }

    }
}
