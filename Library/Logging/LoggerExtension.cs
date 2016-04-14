using System;
using Itera.Fagdag.November.Logging.Contract;

namespace Itera.Fagdag.November.Logging
{
    public static class LoggerExtension
    {
        public static string BuildExceptionMessage(this ILogger logger, Exception exception)
        {
            var logException = exception;
            if (exception.InnerException != null)
                logException = exception.InnerException;

            var strErrorMsg = Environment.NewLine + "Message :" + logException.Message;

            strErrorMsg += Environment.NewLine + "Source :" + logException.Source;

            strErrorMsg += Environment.NewLine + "Stack Trace :" + logException.StackTrace;

            strErrorMsg += Environment.NewLine + "TargetSite :" + logException.TargetSite;
            return strErrorMsg;
        }
    }
}
