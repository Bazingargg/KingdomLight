// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ActionGameRuntime : ModuleRules
{
	public ActionGameRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				/*"LyraGame",*/
				"ModularGameplay",
				/*"CommonGame",*/
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"GameplayTags",
				"GameplayTasks",
				"GameplayAbilities",
				/*"GameplayMessageRuntime",*/
				"CommonUI",
				"UMG",
				"DataRegistry",
				/*"AsyncMixin",*/
				"EnhancedInput",
				/*"GameSubtitles",*/
				"DeveloperSettings",
				"AIModule", 
				
				"InputCore",
				"NetCore",
				"Niagara",
				"MotionWarping"
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
