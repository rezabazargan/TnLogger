using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Test
{
    class ExceptionInterpreter : IInterpreter
    {
        public Func<object, bool> When
        {
            get
            {
                return c => {
                    return c.GetType() == typeof(Exception);
                };
            }
        }

        public ILogModel Interprete(object obj)
        {
            Exception ex = (Exception)obj;
            return new LogModel() {
                CreateDate = DateTime.Now,
                Description = ex.Message,
                Title = "Exception",
                LogType = LogType.Error,
                Periority = Periority.High,
                User = ""
            };
        }
    }
}
