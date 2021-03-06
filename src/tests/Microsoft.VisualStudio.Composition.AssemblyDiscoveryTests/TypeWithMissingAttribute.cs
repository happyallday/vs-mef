﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.Composition.AssemblyDiscoveryTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.Composition.MissingAssemblyTests;

    /// <summary>
    /// This type is here to be a thorn in the side of assembly discovery code.
    /// It has an attribute that comes from an assembly that will be missing at runtime.
    /// </summary>
    [NotFound]
    public class TypeWithMissingAttribute
    {
    }
}
