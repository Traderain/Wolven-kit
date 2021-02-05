using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapStealthMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(4)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(5)]  [RED("aboveWidget")] public wCHandle<inkWidget> AboveWidget { get; set; }
		[Ordinal(6)]  [RED("belowWidget")] public wCHandle<inkWidget> BelowWidget { get; set; }
		[Ordinal(7)]  [RED("visionConeWidget")] public inkImageWidgetReference VisionConeWidget { get; set; }
		[Ordinal(8)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(9)]  [RED("stealthMappin")] public wCHandle<gamemappinsStealthMappin> StealthMappin { get; set; }
		[Ordinal(10)]  [RED("fadeOutAnim")] public CHandle<inkanimProxy> FadeOutAnim { get; set; }
		[Ordinal(11)]  [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(12)]  [RED("wasVisible")] public CBool WasVisible { get; set; }
		[Ordinal(13)]  [RED("attitudeState")] public CName AttitudeState { get; set; }
		[Ordinal(14)]  [RED("preventionState")] public CName PreventionState { get; set; }
		[Ordinal(15)]  [RED("pulsing")] public CBool Pulsing { get; set; }
		[Ordinal(16)]  [RED("hasBeenLooted")] public CBool HasBeenLooted { get; set; }
		[Ordinal(17)]  [RED("isAggressive")] public CBool IsAggressive { get; set; }
		[Ordinal(18)]  [RED("detectionAboveZero")] public CBool DetectionAboveZero { get; set; }
		[Ordinal(19)]  [RED("isAlive")] public CBool IsAlive { get; set; }
		[Ordinal(20)]  [RED("wasAlive")] public CBool WasAlive { get; set; }
		[Ordinal(21)]  [RED("wasCompanion")] public CBool WasCompanion { get; set; }
		[Ordinal(22)]  [RED("couldSeePlayer")] public CBool CouldSeePlayer { get; set; }
		[Ordinal(23)]  [RED("isPrevention")] public CBool IsPrevention { get; set; }
		[Ordinal(24)]  [RED("isCrowdNPC")] public CBool IsCrowdNPC { get; set; }
		[Ordinal(25)]  [RED("cautious")] public CBool Cautious { get; set; }
		[Ordinal(26)]  [RED("shouldShowVisionCone")] public CBool ShouldShowVisionCone { get; set; }
		[Ordinal(27)]  [RED("isDevice")] public CBool IsDevice { get; set; }
		[Ordinal(28)]  [RED("isCamera")] public CBool IsCamera { get; set; }
		[Ordinal(29)]  [RED("isTurret")] public CBool IsTurret { get; set; }
		[Ordinal(30)]  [RED("isNetrunner")] public CBool IsNetrunner { get; set; }
		[Ordinal(31)]  [RED("isHacking")] public CBool IsHacking { get; set; }
		[Ordinal(32)]  [RED("isSquadInCombat")] public CBool IsSquadInCombat { get; set; }
		[Ordinal(33)]  [RED("wasSquadInCombat")] public CBool WasSquadInCombat { get; set; }
		[Ordinal(34)]  [RED("defaultOpacity")] public CFloat DefaultOpacity { get; set; }
		[Ordinal(35)]  [RED("adjustedOpacity")] public CFloat AdjustedOpacity { get; set; }
		[Ordinal(36)]  [RED("defaultConeOpacity")] public CFloat DefaultConeOpacity { get; set; }
		[Ordinal(37)]  [RED("detectingConeOpacity")] public CFloat DetectingConeOpacity { get; set; }
		[Ordinal(38)]  [RED("numberOfShotAttempts")] public CUInt32 NumberOfShotAttempts { get; set; }
		[Ordinal(39)]  [RED("highestLootQuality")] public CUInt32 HighestLootQuality { get; set; }
		[Ordinal(40)]  [RED("lockLootQuality")] public CBool LockLootQuality { get; set; }
		[Ordinal(41)]  [RED("highLevelState")] public CEnum<gamedataNPCHighLevelState> HighLevelState { get; set; }
		[Ordinal(42)]  [RED("iconWidgetGlitch")] public CHandle<inkWidget> IconWidgetGlitch { get; set; }
		[Ordinal(43)]  [RED("visionConeWidgetGlitch")] public CHandle<inkWidget> VisionConeWidgetGlitch { get; set; }
		[Ordinal(44)]  [RED("clampArrowWidgetGlitch")] public CHandle<inkWidget> ClampArrowWidgetGlitch { get; set; }
		[Ordinal(45)]  [RED("showAnim")] public CHandle<inkanimProxy> ShowAnim { get; set; }
		[Ordinal(46)]  [RED("alertedAnim")] public CHandle<inkanimProxy> AlertedAnim { get; set; }
		[Ordinal(47)]  [RED("preventionAnimProxy")] public CHandle<inkanimProxy> PreventionAnimProxy { get; set; }

		public gameuiMinimapStealthMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
