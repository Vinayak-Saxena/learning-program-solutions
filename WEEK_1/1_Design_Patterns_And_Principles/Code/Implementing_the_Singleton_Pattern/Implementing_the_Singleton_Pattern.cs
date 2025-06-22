
public class Logger
{
    private static readonly Logger instance;

    static Logger()
    {
        instance = new Logger();
    }

    private Logger()
    {
        Console.WriteLine("Initialized");
    }

    public static Logger GetInstance() => instance;

    public void Log(string msg)
    {
        Console.WriteLine($"Log: {msg}");
    }
}

public class Program
{
    public static void Main()
    {
        var log1 = Logger.GetInstance();
        log1.Log("App started [Instance 1]");

        var log2 = Logger.GetInstance();
        log2.Log("App running [Instance 2]");

        Console.WriteLine($"Same instance: {ReferenceEquals(log1, log2)}");
    }
}
