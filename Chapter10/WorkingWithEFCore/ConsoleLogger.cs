using Microsoft.Extensions.Logging;
using static System.Console;

namespace Packt.Shared;

public class ConsoleLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
    {
        return new ConsoleLogger();
    }

    public void Dispose() { }
}

public class ConsoleLogger : ILogger
{
    public IDisposable BeginScope<TState>(TState state)
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        switch (logLevel)
        {
            case LogLevel.Trace:
            case LogLevel.Information:
            case LogLevel.None:
                return false;
            case LogLevel.Debug:
            case LogLevel.Warning:
            case LogLevel.Error:
            case LogLevel.Critical:
            default:
                return true;

        }
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {

        // only output the state or exception if it exists
        if (eventId.Id == 20100)
        {

            Console.WriteLine("Level: {0}, Event Id: {1}, Event: {2}",
                logLevel, eventId.Id, eventId.Name);

            if (state != null)
            {
                Console.WriteLine($", State: {state}");
            }

            if (exception != null)
            {
                Console.WriteLine($", Exception: {exception.Message}");
            }

            Console.WriteLine();
        }
    }
}