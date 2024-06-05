using Booker.Application.Shared.Abstraction;
using NLog;

namespace Booker.Infrastructure.Logging;

public class LogingManager : ILogingManager
{
    private static ILogger _logger = LogManager.GetCurrentClassLogger();
    public void LogError(string message) => _logger.Error(message);

    public void LogInfo(string message) => _logger.Info(message);

    public void LogWarn(string message) => _logger.Warn(message);

    public void LogDebug(string message) => _logger.Debug(message);
}