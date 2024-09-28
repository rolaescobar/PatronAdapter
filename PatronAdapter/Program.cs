using PatronAdapter;


class Program
{
    static void Main(string[] args)
    {
        // Uso del adaptador
        var fileLogger = new FileLogger();
        var logger = new LoggerAdapter(fileLogger);
        var app = new Application(logger);
        app.Process();


        //**********************************************************************

        Console.WriteLine("Log registrado en archivo.");

        // Uso del adaptador para registrar en la consola
        // Uso directo de ConsoleLogger
        var consoleLogger = new ConsoleLogger();
        var appConsole = new Application(consoleLogger); // Uso directo ya que ConsoleLogger implementa ILogger
        appConsole.Process();
        Console.WriteLine("Log registrado en consola.");


    }
}


