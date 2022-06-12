using TriangleClassLibrary;
using Tools;

namespace ProgramUI
{
    internal class Program
    {
        private static void Main()
        {
            ConsoleUserInteract.SayHello();

            Triangle triangle = null;

            bool triangleCreated = false;
            while (!triangleCreated)
            {
                double[] sides;
                while (!ConsoleUserInteract.ProcessInput(out sides)) { }

                triangleCreated = TryCreateTriangle(sides, out triangle);
            }

            ConsoleUserInteract.ShowResult(triangle);
        }

        public static bool TryCreateTriangle(double[] sides, out Triangle triangle)
        {
            int sideA = 0, sideB = 1, sideC = 2;

            triangle = null;

            try
            {
                triangle = Triangle.Create(sides[sideA], sides[sideB], sides[sideC]);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}
