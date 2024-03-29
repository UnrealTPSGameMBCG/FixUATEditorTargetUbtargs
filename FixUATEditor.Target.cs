// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;
using System;
using EpicGames.Core;

public class FixUATEditorTarget : TargetRules
{
    [CommandLine("-MyCustomParam")]
    public bool MyCustomParam = false;

	public FixUATEditorTarget(TargetInfo Target) : base(Target)
	{
        Console.WriteLine("FixUAT EditorTarget MyCustomParam ---------------->");
        Console.WriteLine("FixUAT EditorTarget MyCustomParam ----------------> {0}", MyCustomParam);
        Console.WriteLine("FixUAT EditorTarget MyCustomParam ---------------->");
        if (MyCustomParam)
        {
            ProjectDefinitions.Add("MY_CUSTOM_PARAM");
        }

		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "FixUAT" } );
	}
}
