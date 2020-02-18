using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MachineService
{
    static class Program
    {
        #region Log
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("MachineService", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }
        #endregion
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
            // 테스트용
            //Service1 service = new Service1();
            //service.OnStart();
            //Console.ReadKey();
        }
    }
}
