// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MultiplayerTutorial : ModuleRules
{
	public MultiplayerTutorial(ReadOnlyTargetRules Target) : base(Target)
	{
        bEnableExceptions = true;
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "GameLiftClientSDK", "GameLiftServerSDK" });

    }
}
