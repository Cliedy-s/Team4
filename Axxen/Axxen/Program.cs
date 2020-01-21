using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Core;
namespace Axxen
{
    static class Program
    {
        private static LoggingUtility _logging = LoggingUtility.GetLoggingUtility("MyProject", Level.Info);
        internal static LoggingUtility Log
        {
            get { return _logging; }
        }
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;//트라이케치를 선언안한 오류를 받는 곳
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //처리되지않은 예외가있다면


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


            // ****************************사용법*********************************************** 
            //try
            //{

            //    int[] arr = { 1, 2, 3 };
            //    int k = arr[0] + arr[3];

            //}
            //catch (Exception err)
            //{
            //    Program.Log.WriteError("배열의 인덱스 범위를 벗어났습니다", err);

            //}


        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.WriteError(e.Exception.Message, e.Exception);

        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception err = (Exception)e.ExceptionObject;
            Log.WriteError(err.Message, err);
        }
    }
}
