using System;
using System.Collections.Generic;
using System.IO;

namespace PointProcessor
{
	public class Processor
    {
        public static void ProcessFiles(string[] filenames)
        {
            foreach (string file in filenames)
            {
                using (var sr = new StreamReader(file))
                {
                    string line;
                    var lines = new List<string>();

                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }

                    ProcessLines(lines);
                }
            }
        }

        public static void ProcessConsole()
        {
            string line;
            var lines = new List<string>();

            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                lines.Add(line);
            }

            Console.WriteLine();

            ProcessLines(lines);
        }

        public static string ProcessLine(string line)
        {
            Point point;

            if (Parser.TryParsePoint(line, out point))
            {
                return Formatter.Format(point);
            }
            else
            {
                return null;
            }
        }

        private static void ProcessLines(List<string> lines)
        {
            foreach (var line in lines)
            {
                string output = ProcessLine(line);
                Console.WriteLine(output);
            }
        }
    }
}
