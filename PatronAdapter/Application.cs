namespace PatronAdapter
{

    // Cliente que usa ILogger

    public class Application
    {
        private ILogger _logger;

        // Constructor
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            _logger.Log("********* Proceso ejecutado en aplicación *********");
        }
    }
}
