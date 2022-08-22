using System.Diagnostics;

namespace DotNetCourse.MultithreadingBasicsApp
{
    internal static class Logger
    {
        private static readonly object _locker = new();

        public static void Initialize(string outputDirectoryPath, string outputFileName)
        {
            if (!Directory.Exists(outputDirectoryPath))
                Directory.CreateDirectory(outputDirectoryPath);

            string outputFilePath = Path.Combine(outputDirectoryPath, outputFileName);

            var outputFile = File.Create(outputFilePath);

            var textWriterTraceListener = new TextWriterTraceListener(outputFile);

            Trace.Listeners.Add(textWriterTraceListener);
        }

        public static void WriteMessage(string threadName, string message)
        {
            lock (_locker)
            {
                Trace.WriteLine($"[{DateTime.Now:yyyy/MM/dd HH:mm:ss.ffffff}] [{threadName}] {message}");

                Trace.Flush();
            }
        }
    }
}
