using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Configuration
{
    public class ConfigBuilder
    {
        private Configs component;
        public ConfigBuilder(Configs c)
        {
            this.component = c;
        }

        #region [floent]
        public ConfigBuilder AddProvider(IProvider provider)
        {
            component.AddProvider(provider);
            return this;
        }
        public ConfigBuilder AddInterpreter(IInterpreter interpreter)
        {
            component.AddInterpreter(interpreter);
            return this;
        }
        #endregion
    }
}
