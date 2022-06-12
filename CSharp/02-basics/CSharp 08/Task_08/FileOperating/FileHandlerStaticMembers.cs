using System.Text;

namespace Task_08.FileOperating
{
    public partial class FileHandler : IDisposable
    {
        private static void CheckForNull(object obj, Type type, string name)
        {
            if (obj == null) throw new NullReferenceException($"Object '{name}' [{type}] was null.");
        }
        private static void CheckForNegativeOrZero(int number, string name)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException($"Parameter {name} cannot be less or equal Zero.");
        }
        private static void CheckForPathNotExist(string path)
        {
            if (File.Exists(path))
            {
                throw new Exception($"Cannot create [{path}] because it's already exists.");
            }
        }
        private static void CheckForPathExist(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"Cannot access [{path}] because it's doesn't exist.");
            }
        }
        private static Encoding SetEncoding(int codepage)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            return Encoding.GetEncoding(codepage);
        }
        private static char[] CreateSingleCharArray(int size, char c)
        {
            char[] chars = new char[size];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = c;
            }

            return chars;
        }
    }
}
