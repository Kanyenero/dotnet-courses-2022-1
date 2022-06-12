using Tools.ProgramUserInteraction;

namespace Euclidean.Math.UI
{
    internal class Program
    {
        private static void Main()
        {
            ByConsole.PrintMessage("Program calculates greatest common divisor of any number of integers.\n" +
                                   "Input numbers separated by spaces.\n" +
                                   "Press 'Enter' to terminate input.");

            bool workDone = false;
            while (!workDone)
            {
                int[] numbers;
                while (!ByConsole.ProcessInput(out numbers)) { }

                int gcd;
                TimeSpan elapsedTime;

                try
                {
                    gcd = Arithmetic.CalculateGCD(out elapsedTime, numbers);
                }
                catch (Exception ex)
                {
                    ByConsole.PrintMessage(ex.Message);
                    continue;
                }

                ByConsole.PrintMessage("GCD: " + gcd.ToString() + ", Elapsed time: " + elapsedTime.ToString());

                workDone = true;
            }
        }
    }
}
