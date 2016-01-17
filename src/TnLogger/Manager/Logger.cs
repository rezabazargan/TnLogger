using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Configuration;

namespace TnLogger.Manager
{
    public class Logger
    {

        private Configs Config = Configs.Current;

        public void Log(object obj)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
                Config.Providers.Log(model);
        }

    }
}
