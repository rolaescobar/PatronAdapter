namespace PatronAdapter
{

    // Adaptador que hace compatible FileLogger con ILogger


    public class LoggerAdapter : ILogger
    {
        private FileLogger _fileLogger;

        // Constructor
        public LoggerAdapter(FileLogger fileLogger)
        {
            _fileLogger = fileLogger;
        }

        public void Log(string message)
        {
            _fileLogger.LogToFile(message);
        }
    }
}
