﻿using System.Collections.Generic;
using System.Reflection.Metadata;

namespace FlubuCore.Scripting.Analysis
{
    public class ScriptAnalyzerResult
    {
        public string ClassName { get; set; }

        public int? NamespaceIndex { get; set; }

        public List<AssemblyInfo> AssemblyReferences { get; } = new List<AssemblyInfo>();

        public List<string> CsFiles { get; } = new List<string>();

        public List<NugetPackageReference> NugetPackageReferences { get; } = new List<NugetPackageReference>();
    }
}
