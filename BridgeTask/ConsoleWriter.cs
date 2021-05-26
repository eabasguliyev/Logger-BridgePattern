using System;

namespace BridgeTask
{
    public class ConsoleWriter:IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}