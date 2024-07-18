using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace DllDependencyExtractor
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Error(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }
}
