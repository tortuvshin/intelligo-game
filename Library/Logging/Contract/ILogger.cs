using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera.Fagdag.November.Logging.Contract
{
   public interface ILogger
    {
        void Info(string message);
        void Warn(string message);
        void Trace(string message);
        void Debug(string message);
        void Error(string message);
        void Error(Exception exception);
        void Fatal(string message);
        void Fatal(Exception ex);
    }
}
