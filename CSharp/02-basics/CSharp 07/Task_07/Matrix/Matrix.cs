using System.Text;

namespace MatrixLib
{
    public class Matrix
    {
        #region [Fields]
        private readonly double[,] _matrix;
        #endregion

        #region [Props]
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public int Length { get { return Rows * Cols; } }
        #endregion

        #region [Indexers]
        public double this[int row, int col]
        {
            get { return _matrix[row, col]; }
            set { _matrix[row, col] = value; }
        }
        #endregion

        #region [Constructors]
        public Matrix(int rows, int cols)
        {
            ValidateDimension(rows);
            ValidateDimension(cols);

            Rows = rows;
            Cols = cols;

            _matrix = new double[Rows, Cols];
        }
        public Matrix(double[,] matrix) : this(matrix.GetLength(0), matrix.GetLength(1))
        {
            ValidateNotNull(matrix);

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    _matrix[i, j] = matrix[i, j];
                }
        }
        #endregion

        #region [Validation]
        private static void ValidateDimension(int dimension)
        {
            if (dimension <= 0) throw new ArgumentException("Cannot create matrix with negative or zero dimension size");
        }
        private static void ValidateNotNull(double[,] array)
        {
            if (array == null) { throw new NullReferenceException("An error occured: [Constructor parameter was null]"); }
        }
        private static void ValidateNotNull(Matrix mx)
        {
            if (mx == null) { throw new NullReferenceException("An error occured: [Matrix was null]"); }
        }
        private static void ValidateMatricesDimensionEquals(Matrix mx1, Matrix mx2)
        {
            if (mx1.Rows != mx2.Rows || mx1.Cols != mx2.Cols) throw new MatrixException("An error occured: [Matrices dimensions are not equal]", mx1, mx2);
        }
        private static void ValidateMatricesDimensionConsistent(Matrix mx1, Matrix mx2)
        {
            if (mx1.Cols != mx2.Rows || mx1.Rows != mx2.Cols) { throw new MatrixException("An error occured: [Matrices are inconsistent]", mx1, mx2); }
        }
        #endregion


        #region [Overrides]
        public static Matrix operator +(Matrix mx1, Matrix mx2)
        {
            ValidateNotNull(mx1);
            ValidateNotNull(mx2);
            ValidateMatricesDimensionEquals(mx1, mx2);

            var result = new Matrix(mx1.Rows, mx1.Cols);

            for (int i = 0; i < result.Rows; i++)
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = mx1[i, j] + mx2[i, j];
                }

            return result;
        }
        public static Matrix operator -(Matrix mx1, Matrix mx2)
        {
            ValidateNotNull(mx1);
            ValidateNotNull(mx2);
            ValidateMatricesDimensionEquals(mx1, mx2);

            var result = new Matrix(mx1.Rows, mx1.Cols);

            for (int i = 0; i < result.Rows; i++)
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = mx1[i, j] + mx2[i, j];
                }

            return result;
        }
        public static Matrix operator *(Matrix mx1, Matrix mx2)
        {
            ValidateNotNull(mx1);
            ValidateNotNull(mx2);
            ValidateMatricesDimensionConsistent(mx1, mx2);

            var result = new Matrix(mx1.Rows, mx2.Cols);

            for (int i = 0; i < mx1.Rows; i++)
                for (int j = 0; j < mx2.Cols; j++)
                    for (int k = 0; k < mx1.Cols; k++)
                    {
                        result[i, j] += mx1[i, k] * mx2[k, j];
                    }

            return result;
        }
        public static bool operator ==(Matrix mx1, Matrix mx2)
        {
            if (ReferenceEquals(mx1, null))
            {
                if (ReferenceEquals(mx2, null))
                    return true;

                return false;
            }

            return mx1.Equals(mx2);
        }
        public static bool operator !=(Matrix mx1, Matrix mx2) => !(mx1 == mx2);

        public bool Equals(Matrix other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    if (_matrix[i, j] != other[i, j]) { return false; }
                }

            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals((Matrix)obj);
        }

        public override int GetHashCode()
        {
            int hash = 17;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    hash = hash * 31 + _matrix[i, j].GetHashCode();
                }

            return hash;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                sb.Append('[');

                for (int j = 0; j < Cols; j++)
                {
                    sb.Append(_matrix[i, j]);
                    if (j == Cols - 1) { continue; }
                    sb.Append(", ");
                }

                sb.Append(']');
                sb.AppendLine();
            }

            return sb.ToString();
        }
        #endregion
    }
}