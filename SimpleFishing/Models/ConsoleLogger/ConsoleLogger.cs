using System;

public class ConsoleLogger : IConsoleLogger
{
    public void Log<T>(T message)
    {
        Console.WriteLine(message);
    }
}