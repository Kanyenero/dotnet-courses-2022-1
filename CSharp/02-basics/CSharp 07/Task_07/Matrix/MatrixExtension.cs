namespace MatrixLib
{
    public static class MatrixExtension
    {
        public static Matrix Resize(this Matrix originalMx, int rows, int cols)
        {
            var newMx = new Matrix(rows, cols);

            int minRows = Math.Min(rows, originalMx.Rows);
            int minCols = Math.Min(cols, originalMx.Cols);

            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                {
                    newMx[i, j] = originalMx[i, j];
                }

            return newMx;
        }
    }
}
