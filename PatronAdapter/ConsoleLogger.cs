namespace PatronAdapter
{

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log en la consola: " + message);
        }
    }
}
