using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TnLogger.Contracts
{
    /// <summary>
    /// Provide a store function
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// a condition to allow this provider execute.
        /// </summary>
        Func<ILogModel, bool> Condition { get; }

        /// <summary>
        /// implemen a way to store a log
        /// </summary>
        /// <param name="log"></param>
        void Log(ILogModel log);
    }
}
