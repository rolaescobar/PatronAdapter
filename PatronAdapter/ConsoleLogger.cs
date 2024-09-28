namespace PatronAdapter
{
    // Implementación antigua que sólo imprime en la consola

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log to console: " + message);
        }
    }
}
