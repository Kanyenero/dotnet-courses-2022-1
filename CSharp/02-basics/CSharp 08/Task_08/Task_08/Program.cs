using Task_08.FileOperating;

namespace Task_08.FileOperatingUI
{
    internal class Program
    {
        private static void Main()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.ToString() + "test.txt";

            // Создание файла
            //var fileOperatingTool = FileHandler.Create(path, 10);
            //fileOperatingTool.Dispose();

            // Чтение файла
            var fileOperatingTool = FileHandler.Read(path);
            

            // 1) Сохраняет в файл строку вида "[01] Привет мир!" с использованием созданного класса.
            //     Освобождает ресурсы с применением try/finally

            try
            {
                string s = "[01] Hello, world!";

                for (int i = 0; i < s.Length; i++)
                {
                    fileOperatingTool[i] = s[i];
                }
            }
            finally
            {
                fileOperatingTool.Dispose();
            }

            // 2) С помощью созданного класса открывает созданный файл и отображает его содержимое на консоль.
            //    Освобождает ресурсы с применением using

            using (fileOperatingTool = FileHandler.Read(path))
            {
                int idx = 0;

                while (idx < fileOperatingTool.Length)
                {
                    Console.Write(fileOperatingTool[idx]);
                    idx++;
                }

                Console.WriteLine();
            }

            // 3) С помощью созданного класса открывает созданный файл (в пункте 2) и изменяет в нём один символ, чтобы в файле получилось "[02] Привет мир!".
            //    Освобождает ресурсы с применением using

            using (fileOperatingTool = FileHandler.Read(path))
            {
                fileOperatingTool[2] = '2';
            }

            // 4) Выполните шаг 2)

            using (fileOperatingTool = FileHandler.Read(path))
            {
                int idx = 0;

                while (idx < fileOperatingTool.Length)
                {
                    Console.Write(fileOperatingTool[idx]);
                    idx++;
                }

                Console.WriteLine();
            }
        }
    }
}
