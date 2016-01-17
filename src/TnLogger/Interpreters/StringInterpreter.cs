using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Interpreters
{
    /// <summary>
    /// default interpreter for strings
    /// </summary>
    public class StringInterpreter : IInterpreter
    {
        public Func<object, bool> When
        {
            get
            {
                return o => {
                    return o.GetType() == typeof(string);
                };
            }
        }

        public ILogModel Interprete(object obj)
        {
            return new LogModel() {
                CreateDate = DateTime.Now,
                Description = obj.ToString(),
                LogType = LogType.Warning,
                Title = obj.ToString(),
                Periority = Periority.Medium,
                User = ""
            };
        }
    }
}
