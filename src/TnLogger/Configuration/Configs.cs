using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;
using TnLogger.Manager;

namespace TnLogger.Configuration
{
    public class Configs
    {
        private static Configs _current;
        public static Configs Current
        {
            get
            {
                if (_current == null)
                    _current = new Configs();
                return _current;
            }
        }

        #region [provider]
        internal LogProviderCollection Providers
        {
            get
            {
                if (_providers == null)
                    _providers = new LogProviderCollection();
                return _providers;
            }
        }
        private LogProviderCollection _providers;
        public void AddProvider(IProvider provider)
        {
            Providers.Add(provider);
        }
        #endregion

        #region [Interpreters]
        private LogInterpreterCollection _interpreters;
        internal LogInterpreterCollection Interpreters
        {
            get
            {
                if (_interpreters == null)
                    _interpreters = new LogInterpreterCollection();
                return _interpreters;
            }
        }
        public void AddInterpreter(IInterpreter interpreter)
        {
            Interpreters.Add(interpreter);
        }
        #endregion
    }
}
