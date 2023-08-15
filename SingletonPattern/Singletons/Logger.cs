using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singletons
{
    public interface ILogger
    {
        string GetLogs();
        void Log(string message);
    }
    public class Logger : ILogger
    {
        private readonly StringBuilder _logs = new StringBuilder();

        
        public void Log(string message)
        {
            _logs.AppendLine($"{DateTime.Now}: {message}");
        }
        public string GetLogs()
        {
            return _logs.ToString();
        }
    }
}
