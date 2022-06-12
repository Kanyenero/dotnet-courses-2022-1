using VectorLib;
using Tools.ProgramUserInteraction;

namespace VectorUI
{
    internal class Program
    {
        private static void Main()
        {
            ByConsole.PrintMessage("Program tests 3D vector.\n" +
                                   "Input 3D vector values separated by spaces.\n" +
                                   "Press 'Enter' to terminate input.");

            bool workDone = false;
            while (!workDone)
            {
                double[] numbers;
                while (!ByConsole.ProcessInput(out numbers)) { }

                Vector3D vec3D;
                int x = 0, y = 1, z = 2;

                try
                {
                    vec3D = new Vector3D(numbers[x], numbers[y], numbers[z]);
                }
                catch (Exception ex)
                {
                    ByConsole.PrintMessage(ex.Message);
                    continue;
                }

                ByConsole.PrintMessage($"Vector3D [{vec3D}], Length [{vec3D.Length()}]");

                workDone = true;
            }
        }
    }
}
