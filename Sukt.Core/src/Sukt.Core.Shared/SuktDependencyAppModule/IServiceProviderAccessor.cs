﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sukt.Core.Shared.SuktDependencyAppModule
{
    /// <summary>
    /// 服务提供者访问器接口
    /// </summary>
    public interface IServiceProviderAccessor
    {
        IServiceProvider ServiceProvider { get; }
    }
}
