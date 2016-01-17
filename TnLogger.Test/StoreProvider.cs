using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Test
{
    public class StoreProvider : IProvider
    {
        public static List<ILogModel> Errors = new List<ILogModel>();

        public Func<ILogModel, bool> Condition
        {
            get
            {
                return c => {
                    return c.LogType == LogType.Error;
                };
            }
        }

        public void Log(ILogModel log)
        {
            Errors.Add(log);
        }
    }
}
