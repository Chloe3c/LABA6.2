namespace classlib
{
    public class Class1
    {
        public static double[] GetMaxElements(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            double[] maxElements = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double max = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxElements[i] = max;
            }

            return maxElements;
        }
    }
}