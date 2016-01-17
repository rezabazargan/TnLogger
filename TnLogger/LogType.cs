using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TnLogger
{
    /// <summary>
    /// types of tispoon loges
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// when an exception rased
        /// </summary>
        Error,
        /// <summary>
        /// when a none cretical exception rased or some problem 
        /// </summary>
        Warning,
        /// <summary>
        /// when you want to log an info
        /// </summary>
        Info
    }
}
