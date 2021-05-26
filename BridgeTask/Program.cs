using System;
using System.Buffers;

namespace BridgeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();

            SimpleLogger simpleLoggerConsole = new SimpleLogger(consoleWriter);
            DetailedLogger detailedLoggerConsole = new DetailedLogger(consoleWriter);

            string message = "You don't have required privilege!";

            simpleLoggerConsole.LogError(message);
            detailedLoggerConsole.LogError(message);

            TextFileWriter textFileWriter = new TextFileWriter("simpleLog2.txt");

            SimpleLogger simpleLoggerFile = new SimpleLogger(textFileWriter);
            DetailedLogger detailedLoggerFile = new DetailedLogger(textFileWriter);


            simpleLoggerFile.LogError(message);
            simpleLoggerFile.LogError(message);
            simpleLoggerFile.LogError(message);

            textFileWriter.FileName = "detailedLog2.txt";

            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
            detailedLoggerFile.LogError(message);
        }
    }
}
