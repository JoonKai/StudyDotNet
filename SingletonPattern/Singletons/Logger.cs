using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singletons
{
    public class Logger
    {
        private readonly StringBuilder _logs = new StringBuilder();

        private Logger()
        {
            
        }
        //인스턴스를 한번만 생성해주고 또 호출이 되면은 기존 인스턴스를 불러온다.
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());
        public static Logger Instance => _lazyLogger.Value;
        public void Log(string message)
        {
            _logs.AppendLine($"{DateTime.Now}: {message}");
        }
        public string GetLog()
        {
            return _logs.ToString();
        }
    }
}
