using MatrixLib;
using System.Globalization;

namespace MatrixUI
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Type two matrices row by row.");

            int matrixCols = 2;
            int matrixRows = 2;

            var matrix1 = new Matrix(matrixRows, matrixCols);
            var matrix2 = new Matrix(matrixRows, matrixCols);

            GetMatricesFromConsole(matrix1, matrix2);

            Console.WriteLine("\nYour input:\nMatrix 1\n{0}Matrix 2\n{1}", matrix1.ToString(), matrix2.ToString());

            Matrix matrix3;

            matrix3 = matrix1 + matrix2;
            Console.WriteLine("Add operation result:\n{0}", matrix3.ToString());

            matrix3 = matrix1 - matrix2;
            Console.WriteLine("Sub operation result:\n{0}", matrix3.ToString());

            matrix3 = matrix1 * matrix2;
            Console.WriteLine("Mul operation result:\n{0}", matrix3.ToString());
        }

        public static void GetMatricesFromConsole(Matrix matrix1, Matrix matrix2)
        {
            Console.WriteLine("Matrix 1");

            for (int i = 0; i < matrix1.Rows; i++)
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    Console.Write("Value {0}: ", i * matrix1.Cols + j);
                    matrix1[i, j] = GetConsoleInput();
                }

            Console.WriteLine("Matrix 2");

            for (int i = 0; i < matrix2.Rows; i++)
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    Console.Write("Value {0}: ", i * matrix2.Cols + j);
                    matrix2[i, j] = GetConsoleInput();
                }
        }

        private static bool TryGetLine(out string output)
        {
            if ((output = Console.ReadLine()) == null || output == string.Empty)
                return false;

            return true;
        }

        private static double GetConsoleInput()
        {
            bool success = false;
            double value = 0;

            while (!success)
            {
                string line;
                if (!TryGetLine(out line))
                {
                    Console.WriteLine("Input was null or empty. Try again.");
                    continue;
                }
                if (!double.TryParse(line, NumberStyles.Number, CultureInfo.CurrentCulture, out value))
                {
                    Console.WriteLine("Incorrect number. Try again.");
                    continue;
                }

                success = true;
            }

            return value;
        }
    }
}