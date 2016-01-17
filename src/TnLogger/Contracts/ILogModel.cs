using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TnLogger.Contracts
{
    /// <summary>
    /// the base Model of log
    /// </summary>
    public interface ILogModel
    {
        Guid Id { get; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }
        string User { get; set; }
        LogType LogType { get; set; }
        Periority Periority { get; set; }
    }
}
