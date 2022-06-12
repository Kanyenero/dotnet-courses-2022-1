using Tools;

namespace ProgramUI
{
    public static class GetInput
    {
        public static string FromConsole()
        {
            string? input;

            try
            {
                Validate<string>.NotNull(input = Console.ReadLine(), nameof(input));
            }
            catch (ArgumentNullException)
            {
                return string.Empty;
            }

            return input;
        }
    }
}
