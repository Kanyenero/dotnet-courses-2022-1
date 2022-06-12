using PolynomialLib;
using Tools.ProgramUserInteraction;

namespace PolynomialUI
{
    internal class Program
    {
        private static void Main()
        {
            ByConsole.PrintMessage("Program tests Polynomial class.\n" +
                       "Input coefficients separated by spaces.\n" +
                       "Press 'Enter' to terminate input.");

            bool workDone = false;
            while (!workDone)
            {
                double[] numbers1;
                while (!ByConsole.ProcessInput(out numbers1)) { }
                var polyn1 = new Polynomial(numbers1);

                double[] numbers2;
                while (!ByConsole.ProcessInput(out numbers2)) { }
                var polyn2 = new Polynomial(numbers2);

                ByConsole.PrintMessage(polyn1.ToString());
                ByConsole.PrintMessage(polyn2.ToString());

                var polyn3 = polyn1 + polyn2;

                ByConsole.PrintMessage("\nSum operation: ");
                ByConsole.PrintMessage(polyn3.ToString());

                polyn3 = polyn1 - polyn2;

                ByConsole.PrintMessage("\nSub operation: ");
                ByConsole.PrintMessage(polyn3.ToString());

                polyn3 = 10 * polyn3;

                ByConsole.PrintMessage("\nMul operation: ");
                ByConsole.PrintMessage(polyn3.ToString());

                workDone = true;
            }
        }
    }
}