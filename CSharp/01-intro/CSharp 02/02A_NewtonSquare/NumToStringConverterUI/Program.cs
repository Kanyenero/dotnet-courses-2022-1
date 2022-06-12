using NumToStringConverter;

namespace NumToStringConverterUI
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Input non negative integer: ");
            int num = ParseConsoleInput();

            foreach (Converter.BaseSystem item in Enum.GetValues(typeof(Converter.BaseSystem)))
            {
                Console.WriteLine("\n>>> {0}", Enum.GetName(item));

                if(CompareConverters(num, item))
                {
                    Console.WriteLine("Results are equal.");
                    continue;
                }

                Console.WriteLine("Results are not equal.");
            }
        }

        private static int ParseConsoleInput()
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                return num;
            }

            throw new Exception("Cannot parse input :(");
        }

        private static bool CompareConverters(int num, Converter.BaseSystem sys)
        {
            string myConvResult = Converter.ToBase(num, sys);
            string stConvResult = Converter.ToBaseStandard(num, sys);

            Console.WriteLine("{0}\t{1}", myConvResult, stConvResult);

            if (string.Compare(myConvResult, stConvResult) == 0)
            {
                return true;
            }

            return false;
        }
    }
}