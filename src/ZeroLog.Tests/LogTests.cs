﻿using System.Collections.Generic;
using NFluent;
using NUnit.Framework;

namespace ZeroLog.Tests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(Level.Finest, true, true, true, true, true)]
        [TestCase(Level.Verbose, true, true, true, true, true)]
        [TestCase(Level.Debug, true, true, true, true, true)]
        [TestCase(Level.Info, false, true, true, true, true)]
        [TestCase(Level.Warn, false, false, true, true, true)]
        [TestCase(Level.Error, false, false, false, true, true)]
        [TestCase(Level.Fatal, false, false, false, false, true)]
        public void should_return_if_log_level_is_enabled(Level logLevel, bool isDebug, bool isInfo, bool isWarn, bool isError, bool isFatal)
        {
            var logManager = new LogManager(new List<IAppender>(), 1, 128, logLevel);
            var log = new Log(logManager, "logger");

            Check.That(log.IsDebugEnabled).Equals(isDebug);
            Check.That(log.IsInfoEnabled).Equals(isInfo);
            Check.That(log.IsWarnEnabled).Equals(isWarn);
            Check.That(log.IsErrorEnabled).Equals(isError);
            Check.That(log.IsFatalEnabled).Equals(isFatal);
        }
    }
}