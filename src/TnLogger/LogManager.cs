using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Configuration;
using TnLogger.Manager;

namespace TnLogger
{
    public class LogManager
    {
        private static Logger _current;
        public static Logger Current
        {
            get
            {
                if (_current == null)
                    _current = new Logger();
                return _current;
            }
        }

        public static void Config(Action<ConfigBuilder> builder)
        {
            builder(new ConfigBuilder(Configs.Current));
        }

        public static void Log(object obj)
        {
            Current.Log(obj);
        }

    }
}
