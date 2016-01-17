using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TnLogger.Contracts
{
    /// <summary>
    /// Provide an interpreter to compile an object to an Ilog Model
    /// </summary>
    public interface IInterpreter
    {
        Func<object, bool> When { get; }
        ILogModel Interprete(object obj);
    }
}
