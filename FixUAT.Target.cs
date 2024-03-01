// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;
using System;
using EpicGames.Core;

public class FixUATTarget : TargetRules
{
    [CommandLine("-MyCustomParam")]
    public bool MyCustomParam = false;

	public FixUATTarget(TargetInfo Target) : base(Target)
	{
        Console.WriteLine("FixUAT Target MyCustomParam ---------------->");
        Console.WriteLine("FixUAT Target MyCustomParam ----------------> {0}", MyCustomParam);
        Console.WriteLine("FixUAT Target MyCustomParam ---------------->");
        if (MyCustomParam)
        {
            ProjectDefinitions.Add("MY_CUSTOM_PARAM");
        }

		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "FixUAT" } );
	}
}
