// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Authentication.Negotiate
{
    internal class ReflectedNegotiateStateFactory : INegotiateStateFactory
    {
        public INegotiateState CreateInstance()
        {
            return new ReflectedNegotiateState();
        }
    }
}
