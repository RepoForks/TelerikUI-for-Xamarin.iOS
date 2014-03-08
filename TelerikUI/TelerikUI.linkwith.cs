using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("TelerikUI.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "CoreGraphics, CoreAnimation", ForceLoad = true)]
