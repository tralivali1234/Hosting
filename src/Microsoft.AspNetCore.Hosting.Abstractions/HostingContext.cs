﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Hosting
{
    public interface IHostingContext
    {
        IConfiguration Configuration { get; }
        IHostingEnvironment Environment { get; }
        ILoggerFactory LoggerFactory { get; }
    }
}