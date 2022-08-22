namespace DotNetCourse.MultithreadingBasicsApp
{
    internal class SharedResClass
    {
        private readonly ReaderWriterLockSlim _readerWriterLockSlim = new();

        private string _sharedRes = "SharedResContent";

        public string SharedRes
        {
            get
            {
                bool enteredReadLock = _readerWriterLockSlim.TryEnterReadLock(0);

                string currentThreadName = Thread.CurrentThread.Name ?? string.Empty;

                if (!enteredReadLock)
                    Logger.WriteMessage(currentThreadName, "Waiting for a read lock...");

                try
                {
                    if (!enteredReadLock)
                        _readerWriterLockSlim.EnterReadLock();

                    Logger.WriteMessage(currentThreadName, "Acquired a read lock");

                    Thread.Sleep(2000);

                    return _sharedRes;
                }
                finally
                {
                    Logger.WriteMessage(currentThreadName, "Released a read lock");

                    _readerWriterLockSlim.ExitReadLock();
                }
            }
            set
            {
                bool enteredWriteLock = _readerWriterLockSlim.TryEnterWriteLock(0);

                string currentThreadName = Thread.CurrentThread.Name ?? string.Empty;

                if (!enteredWriteLock)
                    Logger.WriteMessage(currentThreadName, "Waiting for a write lock...");

                try
                {
                    if (!enteredWriteLock)
                        _readerWriterLockSlim.EnterWriteLock();

                    Logger.WriteMessage(currentThreadName, "Acquired a write lock");

                    Thread.Sleep(5000);

                    _sharedRes = value;
                }
                finally
                {
                    Logger.WriteMessage(currentThreadName, "Released a write lock");

                    _readerWriterLockSlim.ExitWriteLock();
                }
            }
        }

        ~SharedResClass()
        {
            if (_readerWriterLockSlim != null)
                _readerWriterLockSlim.Dispose();
        }
    }
}
