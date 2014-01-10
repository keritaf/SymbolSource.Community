using System.ComponentModel.Composition;
using NuGetPackageExplorer.Types;

namespace SymbolSource.Integration.NuGet.PackageExplorer
{
    [Export(typeof(IPackageRule))]
    public class SymbolPackageRule : PackageRuleWrapper
    {
        public SymbolPackageRule()
            : base(NuGet.SymbolPackageRule.Validate)
        {
        }
    }
}