using AxxenClient.Forms;
using AxxenClient.Templets;
using AxxenClient.Util;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxxenClient
{
    static class Program
    {
        #region Log
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("AxxenClient", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }
        #endregion
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
