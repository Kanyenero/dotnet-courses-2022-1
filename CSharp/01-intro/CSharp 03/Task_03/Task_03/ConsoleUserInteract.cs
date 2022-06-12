namespace ProgramUI
{
    public static class ConsoleUserInteract
    {
        public static void SayHello()
        {
            Console.WriteLine("Type triangle sides [A, B, C] by space:\nInput");
        }

        public static bool ProcessInput(out double[] triangleSides)
        {
            string input;
            bool inputOk = GetLine(out input);

            string[] inputParts;
            bool splitOk = SplitLine(input, out inputParts);

            bool parseOk = Parse(inputParts, out triangleSides);

            return inputOk && splitOk && parseOk;
        }

        public static void ShowResult(object obj)
        {
            Console.WriteLine(obj.ToString());
        }



        private static bool GetLine(out string input)
        {
            input = GetInput.FromConsole();

            if (input == string.Empty)
            {
                Console.WriteLine($"'{nameof(input)}' was empty.");
                return false;
            }

            return true;
        }

        private static bool SplitLine(string input, out string[] splittedInput)
        {
            splittedInput = input.Split(' ');

            if (splittedInput.Length == 3)
            {
                return true;
            }

            Console.WriteLine("Incorrect sides number.");
            return false;
        }

        private static bool Parse(string[] input, out double[] output)
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
                    Console.Write(ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
