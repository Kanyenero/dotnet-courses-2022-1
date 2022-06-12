using System.Globalization;

namespace Tools.ProgramUserInteraction
{
    public static class ByConsole
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message, CultureInfo.InvariantCulture);
        }
        public static bool ProcessInput(out int[] output)
        {
            bool inputOk = TryGetLine(out string input);
            bool splitOk = TrySplitLine(input, out string[] parts);
            bool parseOk = TryParse(parts, out output);

            return inputOk && splitOk && parseOk;
        }
        public static bool ProcessInput(out double[] output)
        {
            bool inputOk = TryGetLine(out string input);
            bool splitOk = TrySplitLine(input, out string[] parts);
            bool parseOk = TryParse(parts, out output);

            return inputOk && splitOk && parseOk;
        }
        private static bool TryGetLine(out string output)
        {
            output = GetInput.FromConsole();

            if (output == string.Empty)
            {
                Console.WriteLine($"Line was empty.");
                return false;
            }

            return true;
        }
        private static bool TrySplitLine(string input, out string[] output)
        {
            output = input.Split(' ');

            if (output.Length == 0)
            {
                return false;
            }

            return true;
        }
        private static bool TryParse(string[] input, out int[] output)
        {
            output = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    output[i] = int.Parse(input[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }
        private static bool TryParse(string[] input, out double[] output)
        {
            output = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    output[i] = double.Parse(input[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
