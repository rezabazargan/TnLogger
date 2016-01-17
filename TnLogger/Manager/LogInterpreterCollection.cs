using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger.Manager
{
    public class LogInterpreterCollection : List<IInterpreter>
    {
        public ILogModel GetModel(object obj)
        {
            ILogModel model = null;
            this.ForEach(p => {
                if (p.When(obj))
                    model =  p.Interprete(obj);
            });
            return model;
        }
    }
}
