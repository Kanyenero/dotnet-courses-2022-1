using PointProcessor;

namespace PointProcessorUI
{
    internal class Program
    {
        private static void Main(string[] fileNames)
        {
            if (fileNames.Length > 0)
            {
                Processor.ProcessFiles(fileNames);
            }
            else
            {
                Processor.ProcessConsole();
            }
        }
    }
}
