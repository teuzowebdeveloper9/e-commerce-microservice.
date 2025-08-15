using Serilog;

namespace demoeEcommerce.SharedLibrarySolution.logs;

public static class logsException
{
    public static void LogException(Exception ex)
    {
        LogToFile(ex.Message);
        LogToConsole(ex.Message);
        LogToDebug(ex.Message);
    }

    public static void LogToFile(string message) => Log.Information(message);
    public static void LogToConsole(string message) => Log.Information(message);
    public static void LogToDebug(string message) => Log.Information(message);
}