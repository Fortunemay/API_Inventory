namespace Inventory_API.Interface
{
    public interface ILoggerInfo
    {
        void Debug(string? message);
        void Info(string? message);
        void Error(string? message, Exception? ex = null);
    }
}
