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

        Console.WriteLine("Log registrado en archivo.");
    }
}


