using System;

namespace OOP_TimothyHsu.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;
        public static LogMessage[] Logs
        {
            get { return logs; }
            set { logs = value; }
        }
        static LoggerService()
        {
            Logs = new LogMessage[0];
        }
        public static void AddLogMessage(LogMessage message)//increases the array size by 1 and adds a new LogMessage instance to the array
        {
            Array.Resize(ref logs, Logs.Length + 1);
            Logs[Logs.Length - 1] = message;
        }
    }
}
