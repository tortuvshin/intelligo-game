using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Logging.Contract;
using NLog;

namespace Itera.Fagdag.November.Logging
{
    public class NLogLogger : ILogger
    {
        private readonly Logger _logger;

        public NLogLogger()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(this.BuildExceptionMessage(exception));
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception ex)
        {
            _logger.Fatal(this.BuildExceptionMessage(ex));
        }
    }
}