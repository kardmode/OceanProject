using UnrealBuildTool;
using System.IO;

public class OceanPlugin : ModuleRules
{
    private string ModulePath
    {
        get { return Path.GetDirectoryName(ModuleDirectory); }
    }

    private string ThirdPartyPath
    {
        get { return Path.GetFullPath(Path.Combine(ModulePath, "../../ThirdParty/")); }
    }

    public OceanPlugin(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateIncludePaths.AddRange(new string[] { "OceanPlugin/Private" });
       // PublicIncludePaths.AddRange(new string[] { "OceanPlugin/Public" });

        PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "InputCore", "PhysX", "APEX", "ApexDestruction", "Landscape", "RHI", "RenderCore" });
    }
}