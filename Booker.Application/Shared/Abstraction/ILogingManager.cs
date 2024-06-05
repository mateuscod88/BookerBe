namespace Booker.Application.Shared.Abstraction;

public interface ILogingManager
{
    void LogError(string message);
    void LogInfo(string message);
    void LogWarn(string message);
    void LogDebug(string message);
}