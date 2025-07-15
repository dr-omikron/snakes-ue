
using UnrealBuildTool;
using System.Collections.Generic;

public class SnakesEditorTarget : TargetRules
{
	public SnakesEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		ExtraModuleNames.Add("Snakes");
	}
}
