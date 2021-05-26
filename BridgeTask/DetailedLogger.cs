using System;
using System.Text;

namespace BridgeTask
{
    public class DetailedLogger:ILogging
    {
        public IWriter Writer { get; set; }

        public DetailedLogger(IWriter writer)
        {
            Writer = writer;
        }
        public void LogInfo(string message)
        {
            Writer.Write(GetInfo("Info", message));
        }

        public void LogWarning(string message)
        {
            Writer.Write(GetInfo("Warning", message));
        }

        public void LogError(string message)
        {
            Writer.Write(GetInfo("Error", message));
        }

        private string GetInfo(string logType, string message)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Type: {logType}\n");
            sb.Append($"Date: {DateTime.Now.ToShortDateString()}\n");
            sb.Append($"Time: {DateTime.Now.ToShortTimeString()}\n");
            sb.Append($"Message: {message}\n");

            return sb.ToString();
        }
    }
}