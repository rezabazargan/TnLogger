using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Manager
{
    public class LogProviderCollection : List<IProvider>
    {
        public void Log(ILogModel model)
        {
            this.ForEach(p => {
                if (p.Condition != null && p.Condition(model))
                    p.Log(model);
            });
        }
    }
}
