namespace PatronAdapter
{
    public class FileLogger
    {
        public void LogToFile(string message)
        {
            //Guardar el log en la ruta especificada
            string filePath = @"C:\upana\log.txt";
            File.AppendAllText(filePath, message + "\n");
        }
    }
}
