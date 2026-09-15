// Singleton pattern implementation for a logging service

public class LogService  // It creates a single class of the LogService 
{
    private static LogService? _instance;  // The purpose here is to keep one global reference
    private static readonly object _lock = new object();
    private LogService() { }

    public static LogService GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                     _instance = new LogService();
                }
            }
        }
        return _instance;
    }
    public void Registrar(string message)
    {
        Console.WriteLine($"[LOG {DateTime.Now}] {message}");
    }
}
