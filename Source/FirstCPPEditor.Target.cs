// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FirstCPPEditorTarget : TargetRules
{
	public FirstCPPEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        bUseUnityBuild = false;
        bUsePCHFiles = false;

		ExtraModuleNames.AddRange( new string[] { "FirstCPP" } );
	}
}
