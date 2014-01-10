using System.ComponentModel.Composition;
using NuGetPackageExplorer.Types;

namespace SymbolSource.Integration.NuGet.PackageExplorer
{
    [Export(typeof(IPackageRule))]
    public class SourcePackageRule : PackageRuleWrapper
    {
        public SourcePackageRule()
            : base(NuGet.SourcePackageRule.Validate)
        {
        }
    }
}