using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TnLogger.Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            #region [Config Logger]
            LogManager.Config(c => {
                c.AddInterpreter(new ExceptionInterpreter());
                c.AddProvider(new StoreProvider());
            });
            #endregion


            Application.Run(new Form1());
        }
    }
}
