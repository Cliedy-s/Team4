using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axxen
{
    public class LoggingUtility
    {
        private static LoggingUtility _loggingUtility = null;
        private ILog log;
        private RollingFileAppender roller;
        private string logFileName = "MyProject.log";
        private bool runAsConsole = false;
               
        public static LoggingUtility GetLoggingUtility(string loggerName, Level logLevel)
        {
            if (_loggingUtility == null)//외부에만든 객체가 있는지 확인 없다면 하나 만든다.
            {
                _loggingUtility = new LoggingUtility(loggerName, logLevel);
            }

            return _loggingUtility;
        }

        private LoggingUtility(string loggerName, Level logLevel) //싱글톤 한개의 객체만을 만들기위해서 
        {
            SetupLog4net(logLevel, loggerName);
        }

        /// <summary>
        /// Log4net사용을 위한 설정
        /// </summary>
        /// <param name="logLevel">로그 레벨 설정</param>
        public void SetupLog4net(Level logLevel, string loggerName)
        {
            CheckAndCreateLoggingFolder(); //로긴폴더가있는지확인

            ILoggerRepository repository = LogManager.CreateRepository(loggerName);
            Hierarchy hierarchy = (Hierarchy)repository;
            log4net.Repository.Hierarchy.Logger logger = hierarchy.LoggerFactory.CreateLogger((ILoggerRepository)hierarchy, loggerName);
            logger.Hierarchy = hierarchy;
            CreateFileAppender(loggerName);
            logger.AddAppender(this.roller);
            logger.Repository.Configured = true;

            hierarchy.Threshold = logLevel;
            logger.Level = logLevel;

            this.log = new LogImpl(logger);
        }

        private void CreateFileAppender(string loggerName)
        {
            if (roller != null)
            {
                this.CloseRoller();
            }
            //날짜별로할때
            //rollingAppender.RollingStyle = log4net.Appender.RollingFileAppender.RollingMode.Date;
            //rollingAppender.LockingModel = new log4net.Appender.FileAppender.MinimalLock();
            //rollingAppender.DatePattern = "_yyyyMMdd\".log\""; // 날짜가 지나간 경우 이전 로그에 붙을 이름 구성
            //log4net.Layout.PatternLayout layout = new log4net.Layout.PatternLayout("%date [%property{buildversion}] %-5level %logger - %message%newline");

            roller = new RollingFileAppender
            {
                //날자와 사이즈가 합처진거를 사용하고싶을때.
                Name = loggerName + "FileAppender",
                File = GetLoggingFilePath(),
                LockingModel = new FileAppender.MinimalLock(),
                AppendToFile = true,
                RollingStyle = RollingFileAppender.RollingMode.Composite, //날자와 사이즈가 합처진거 
                DatePattern = "_yyyyMMdd\".log\"",
                MaxSizeRollBackups = -1, //어퍼치기 없이 계속싸인다.
                MaximumFileSize = "1MB",
                StaticLogFileName = true,
                Layout = new log4net.Layout.PatternLayout("[%level] %date %-20logger %newline%message%newline") //[INFO] 2020-01-19 21:39:49,388 MyProject 

                //크기별로만들때
                //Name = loggerName + "FileAppender",
                //File = GetLoggingFilePath(),
                //LockingModel = new FileAppender.MinimalLock(),
                //AppendToFile = true,
                //RollingStyle = RollingFileAppender.RollingMode.Size,
                //MaxSizeRollBackups = -1,
                //MaximumFileSize = "1MB",
                //StaticLogFileName = true,
                //Layout = new log4net.Layout.PatternLayout("[%level] %date %-20logger %newline%message%newline") //[INFO] 2020-01-19 21:39:49,388 MyProject   
            };
            roller.ActivateOptions();
        }

        public void CloseRoller()
        {
            if (this != null && this.roller != null && !runAsConsole)
            {
                this.roller.Close();
            }
        }

        /// <summary>
        /// 디버그 정보 쓰기
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void WriteDebug(string message, Exception ex)
        {
            if (!runAsConsole)
                log.Debug(message, ex);
        }

        /// <summary>
        /// 디버그 정보 쓰기
        /// </summary>
        /// <param name="message"></param>
        public void WriteDebug(string message)
        {
            if (!runAsConsole)
                log.Debug(message);
        }

        /// <summary>
        /// 실행 정보 쓰기
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void WriteInfo(string message, Exception ex)
        {
            if (!runAsConsole)
                log.Info(message, ex);
        }


        /// <summary>
        /// 실행 정보 쓰기
        /// </summary>
        /// <param name="message"></param>
        public void WriteInfo(string message)
        {
            if (!runAsConsole)
                log.Info(message);
        }

        /// <summary>
        /// 경고 로그 쓰기
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void WriteWarn(string message, Exception ex)
        {
            if (!runAsConsole)
                log.Warn(message, ex);
        }

        /// <summary>
        /// 경고 로그 쓰기
        /// </summary>
        /// <param name="message"></param>
        public void WriteWarn(string message)
        {
            if (!runAsConsole)
                log.Warn(message);
        }

        /// <summary>
        /// 오류 로그 쓰기
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void WriteError(string message, Exception ex)
        {
            if (!runAsConsole)
                log.Error(message, ex);
        }

        /// <summary>
        /// 오류 로그 쓰기
        /// </summary>
        /// <param name="message"></param>
        public void WriteError(string message)
        {
            if (!runAsConsole)
                log.Error(message);
        }

        /// <summary>
        /// 치명적인 오류 쓰기
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void WriteFatal(string message, Exception ex)
        {
            if (!runAsConsole)
                log.Fatal(message, ex);
        }

        /// <summary>
        /// 치명적인 오류 쓰기
        /// </summary>
        /// <param name="message"></param>
        public void WriteFatal(string message)
        {
            if (!runAsConsole)
                log.Fatal(message);
        }


        /// <summary>
        /// %AppData%\ClipSoft\ClipSoft.eForm.Viewer\Logs 폴더 존재 확인 후 생성
        /// </summary>
        private void CheckAndCreateLoggingFolder()
        {
            string tempFolder = GetLoggingFolder();

            if (!Directory.Exists(tempFolder)) //폴더가있느지 확인
            {
                Directory.CreateDirectory(tempFolder);
            }
        }

        /// <summary>
        /// .\Logs 폴더를 구함
        /// </summary>
        /// <returns></returns>
        private string GetLoggingFolder()
        {
            return @".\Logs"; // string.Format(@"\{0}\{1}\Logs", this.company, this.product);
        }

        /// <summary>
        /// 로깅 파일의 위치를 구함
        /// </summary>
        /// <returns></returns>
        private string GetLoggingFilePath()
        {
            return string.Format(@"{0}\{1}", GetLoggingFolder(), this.logFileName);
        }

        internal static LoggingUtility GetLoggingUtility(string v, object e)
        {
            throw new NotImplementedException();
        }
    }
}
