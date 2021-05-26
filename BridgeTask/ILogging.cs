namespace BridgeTask
{
    public interface ILogging
    {
        IWriter Writer { get; set; }

        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}