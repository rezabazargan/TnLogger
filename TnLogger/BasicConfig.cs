using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Interpreters;

namespace TnLogger
{
    internal class BasicConfig
    {
        internal static void Config()
        {
            LogManager.Config(c => {
                c.AddInterpreter(new StringInterpreter());
            });
        }
    }
}
