using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TnLogger.Contracts
{
    public interface IProvider
    {
        Func<ILogModel, bool> Condition { get; }
        void Log(ILogModel log);
    }
}
