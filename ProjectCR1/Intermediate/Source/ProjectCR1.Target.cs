using UnrealBuildTool;

public class ProjectCR1Target : TargetRules
{
	public ProjectCR1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectCR1");
	}
}
