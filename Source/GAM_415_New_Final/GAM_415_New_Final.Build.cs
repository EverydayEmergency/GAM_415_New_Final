// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GAM_415_New_Final : ModuleRules
{
	public GAM_415_New_Final(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
