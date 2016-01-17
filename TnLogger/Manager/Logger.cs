using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Configuration;

namespace TnLogger.Manager
{
    public class Logger
    {

        public Logger()
        {
            BasicConfig.Config();
        }

        private Configs Config = Configs.Current;

        public void Log(object obj)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
                Config.Providers.Log(model);
        }
        #region [Log overrides]
        public void Log(object obj,string user)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
            {
                model.User = user;
                Config.Providers.Log(model);
            }
        }
        public void Log(object obj,LogType type)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
            {
                model.LogType = type;
                Config.Providers.Log(model);
            }
        }
        public void Log(object obj, Periority p)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
            {
                model.Periority = p;
                Config.Providers.Log(model);
            }
        }
        public void Log(object obj, Periority p,LogType type)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
            {
                model.Periority = p;
                model.LogType = type;
                Config.Providers.Log(model);
            }
        }
        public void Log(object obj, Periority p, LogType type,string user)
        {
            var model = Config.Interpreters.GetModel(obj);
            if (model != null)
            {
                model.Periority = p;
                model.LogType = type;
                model.User = user;
                Config.Providers.Log(model);
            }
        }
        #endregion
    }
}
