using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using Itera.Fagdag.November.Controllers;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Itera.Fagdag.November.App_Start
{
    public static class LoggerConfig
    {
        public static void Configure()
        {
            //Step 1. Create configuration object 
            var loggingConfiguration = new LoggingConfiguration();

            //Step 2. Create targets and add them to the configuration 
            var fileTarget = new FileTarget();
            loggingConfiguration.AddTarget("file", fileTarget);

            //Step 3. Set target properties
            fileTarget.FileName = "${basedir}/Logging/WebApplication.log";
            fileTarget.ArchiveFileName = "${basedir}/Logging/WebApplication.{#####}.txt";
            fileTarget.ArchiveAboveSize = 10240; // 10kb
            fileTarget.ArchiveNumbering = ArchiveNumberingMode.Sequence;
            fileTarget.ConcurrentWrites = true;
            fileTarget.KeepFileOpen = false;
            fileTarget.Layout = "${longdate} | ${level} | ${message}";

            //Step 4. Define rules
            var loggingRule = new LoggingRule("*", LogLevel.Info, fileTarget);
            loggingConfiguration.LoggingRules.Add(loggingRule);

            //Step 5. Activate the configuration
            LogManager.Configuration = loggingConfiguration;
        }
    }
}