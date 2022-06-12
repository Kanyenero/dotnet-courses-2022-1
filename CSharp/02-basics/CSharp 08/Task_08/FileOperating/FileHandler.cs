using System.Text;

namespace Task_08.FileOperating
{
    public partial class FileHandler : IDisposable
    {
        private FileStream _fileStream;
        private StreamReader _streamReader;
        private StreamWriter _streamWriter;

        private readonly string _path;
        private readonly Encoding _encoding;
        private bool _disposed;


        public long Length
        {
            get { return _fileStream.Length; }
        }

        public char this[int idx]
        {
            get { return ReadChar(idx); }
            set { WriteChar(idx, value); }
        }


        public static FileHandler Create(string path, int bufferSize)
        {
            CheckForNegativeOrZero(bufferSize, nameof(bufferSize));
            CheckForNull(path, path.GetType(), nameof(path));
            CheckForPathNotExist(path);

            return new FileHandler(path, bufferSize);
        }
        public static FileHandler Read(string path)
        {
            CheckForNull(path, path.GetType(), nameof(path));
            CheckForPathExist(path);

            return new FileHandler(path);
        }


        private FileHandler(string path, int bufferSize)
        {
            _path = path;
            _encoding = SetEncoding(1252);

            SetupFileStream(FileMode.Create, FileAccess.ReadWrite, FileShare.None);

            if (_fileStream != null)
            {
                Fill(_fileStream, bufferSize, ' ');
            }
        }
        private FileHandler(string path)
        {
            _path = path;
            _encoding = SetEncoding(1252);
            
            SetupFileStream(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
        ~FileHandler()
        {
            Dispose(false);
        }


        private void SetupFileStream(FileMode fm, FileAccess fa, FileShare fs)
        {
            try
            {
                _fileStream = new FileStream(_path, fm, fa, fs);
                _streamWriter = new StreamWriter(_fileStream, _encoding);
                _streamReader = new StreamReader(_fileStream, _encoding, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while FileStream setup:\n[Source: {ex.Source}]\n[Message: {ex.Message}]");
            }
        }


        private void Fill(FileStream fs, int size, char c)
        {
            char[] chars = CreateSingleCharArray(size, c);
            byte[] bytes = _encoding.GetBytes(chars);

            fs.Write(bytes, 0, bytes.Length);
        }


        private char[] ReadToEnd()
        {
            char[] buffer = new char[_fileStream.Length];

            try
            {
                _fileStream.Position = 0;
                _streamReader.Read(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while StreamReader ReadToEnd:\n[Source: {ex.Source}]\n[Message: {ex.Message}]");
            }
            finally
            {
                _streamReader.DiscardBufferedData();
            }

            return buffer;
        }


        private char ReadChar(int idx)
        {
            char[] buffer = new char[1];

            try
            {
                _fileStream.Position = idx;
                _streamReader.Read(buffer, 0, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while StreamReader ReadChar:\n[Source: {ex.Source}]\n[Message: {ex.Message}]");
            }
            finally
            {
                _streamReader.DiscardBufferedData();
            }

            return buffer[0];
        }


        private void WriteChar(int idx, char c)
        {
            try
            {
                _fileStream.Position = idx;
                _streamWriter.Write(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while StreamWriter write:\n[Source: {ex.Source}]\n[Message: {ex.Message}]");
            }
            finally
            {
                _streamWriter.Flush();
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Code to dispose the managed resources of the class
                }

                // Code to dispose the unmanaged resources of the class

                _streamWriter?.Close();
                _streamReader?.Close();
                _fileStream?.Close();

                _disposed = true;
            }
        }
    }
}
