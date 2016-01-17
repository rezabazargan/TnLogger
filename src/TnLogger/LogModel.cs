using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TnLogger.Contracts;

namespace TnLogger
{
    public class LogModel : ILogModel
    {
        public LogModel()
        {
            this.Id = Guid.NewGuid();
        }
        public DateTime CreateDate
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public Guid Id
        {
            get; private set;
        }

        public LogType LogType
        {
            get; set;
        }

        public Periority Periority
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public string User
        {
            get; set;
        }
    }
}
