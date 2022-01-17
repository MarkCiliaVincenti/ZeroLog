﻿using System;
using System.Collections.Generic;
using System.Text;
using ZeroLog.Appenders;

namespace ZeroLog.ConfigResolvers
{
    public interface IConfigurationResolver : IDisposable
    {
        IEnumerable<Appender> GetAllAppenders();
        LogConfig ResolveLogConfig(string name);

        event Action Updated;
    }
}
