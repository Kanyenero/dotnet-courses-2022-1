namespace DotNetCourse.MultithreadingBasicsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.ToString() + "\\logs";
            var logFileName = string.Concat("trace-", DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss"), "-client", ".txt");

            Logger.Initialize(logDir, logFileName);

            string mainThreadName = "App Thread";
            Thread.CurrentThread.Name = mainThreadName;

            Logger.WriteMessage(mainThreadName, "Started");

            // 1. Создайте экземпляр класса, который содержит "синхронное" свойство

            var sharedResClass = new SharedResClass();

            // 2. Создайте 10 потоков читателей, пытающихся прочитать это свойство

            var readerThreads = new List<Thread>();

            for (int i = 1; i <= 10; i++)
            {
                int threadNumber = i;
                var readerThread = new Thread(() => 
                {
                    string threadName = Thread.CurrentThread.Name ?? string.Empty;

                    Logger.WriteMessage(threadName, "Started");

                    ReaderThreadProc(sharedResClass);

                    Logger.WriteMessage(threadName, "Terminated");

                }) { Name = $"Reader {threadNumber}" };

                readerThreads.Add(readerThread);
            }

            // 3. Создайте 2 потока писателей, пытающихся изменить это свойство

            var writerThreads = new List<Thread>();

            for (int i = 1; i <= 2; i++)
            {
                int threadNumber = i;
                var writerThread = new Thread(() =>
                {
                    string threadName = Thread.CurrentThread.Name ?? string.Empty;

                    Logger.WriteMessage(threadName, "Started");

                    WriterThreadProc(sharedResClass);

                    Logger.WriteMessage(threadName, "Terminated");

                }) { Name = $"Writer {threadNumber}" };

                writerThreads.Add(writerThread);
            }

            // 4. Вначале запускайте часть читателей, потом писателя, потом снова читателей, второго писателя и оставшихся читателей

            readerThreads[0].Start();
            readerThreads[1].Start();
            readerThreads[2].Start();

            Thread.Sleep(1000);

            writerThreads[0].Start();

            Thread.Sleep(1000);

            readerThreads[3].Start();
            readerThreads[4].Start();
            readerThreads[5].Start();

            Thread.Sleep(1000);

            writerThreads[1].Start();

            Thread.Sleep(1000);

            readerThreads[6].Start();
            readerThreads[7].Start();
            readerThreads[8].Start();
            readerThreads[9].Start();

            foreach (var readerThread in readerThreads)
                readerThread.Join();

            foreach (var writerThread in writerThreads)
                writerThread.Join();

            Logger.WriteMessage(mainThreadName, "Terminated");
        }

        private static void ReaderThreadProc(SharedResClass sharedResClass)
        {
            string threadName = Thread.CurrentThread.Name ?? string.Empty;

            Logger.WriteMessage(threadName, "Method Started");

            var readResult = sharedResClass.SharedRes;

            Logger.WriteMessage(threadName, $"Method Completed(result: '{readResult}')");
        }

        private static void WriterThreadProc(SharedResClass sharedResClass)
        {
            string threadName = Thread.CurrentThread.Name ?? string.Empty;

            Logger.WriteMessage(threadName, "Method Started");

            sharedResClass.SharedRes = $"SharedResContent (after '{threadName}' changes)";

            Logger.WriteMessage(threadName, "Method Completed");
        }
    }
}
