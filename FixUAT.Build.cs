// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System;
using System.Linq;

public class FixUAT : ModuleRules
{
	public FixUAT(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // PublicIncludePaths.Add("FixUAT");

		Console.WriteLine("FixUAT module rules ---------------->");
		Console.WriteLine(
			"Unreal version {0}.{1}.{2}", Target.Version.MajorVersion, Target.Version.MinorVersion, Target.Version.PatchVersion);
		Console.WriteLine("Target platform {0}", Target.Platform);
		Console.WriteLine("Target type {0}", Target.Type);
		Console.WriteLine("Branch name {0}", Target.Version.BranchName);
        if (Target.ProjectDefinitions.Contains("MY_CUSTOM_PARAM"))
        {
	    	Console.WriteLine("FixUAT module rules ----------------> MY_CUSTOM_PARAM (-MyCustomParam was successfuly passed for this Target)");
        }
    	Console.WriteLine("FixUAT module rules ---------------->");
	}
}
